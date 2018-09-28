using System;
using NUnit.Framework;
using skycoin;
using utils;
namespace LibskycoinNetTest {
    [TestFixture ()]
    public class check_coin_transactions {

        utils.transutils transutils = new utils.transutils ();
        [Test]
        public void TestTransactionVerify () {

            // Mismatch header hash
            var tx = transutils.makeEmptyTransaction ();
            var ptx = skycoin.skycoin.makeTransaction (tx);
            ptx.setInnerHash (new cipher_SHA256 ());
            var err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // No inputs
            tx = skycoin.skycoin.new_Transaction__Handlep ();
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetInputs (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // No outputs
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetOutputs (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK, "");
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // Invalid number of Sigs
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetSignatures (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetSignatures (tx, 20);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // Too many sigs & inputs
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetSignatures (tx, short.MaxValue);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetInputs (tx, short.MaxValue);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // Duplicate inputs
            var ux = new coin__UxOut ();
            var s = new cipher_SecKey ();
            var h = new cipher_SHA256 ();

            skycoin.skycoin.makeUxOutWithSecret (ux, s);
            skycoin.skycoin.makeTransactionFromUxOut (ux, s, tx);
            err = skycoin.skycoin.SKY_coin_Transaction_GetInputAt (tx, 0, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var p1 = skycoin.skycoin.new_GoUint16p ();
            err = skycoin.skycoin.SKY_coin_Transaction_PushInput (tx, h, p1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetSignatures (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var secKeys = new cipher_SecKeys ();
            secKeys.allocate (2);
            secKeys.setAt (0, s);
            secKeys.setAt (1, s);
            err = skycoin.skycoin.SKY_coin_Transaction_SignInputs (tx, secKeys);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // Duplicate outputs
            skycoin.skycoin.makeTransaction (tx);
            var pOutput = new coin__TransactionOutput ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (tx, 0, pOutput);
            pOutput.Address = new cipher__Address ();
            err = skycoin.skycoin.SKY_coin_Transaction_ResetOutputs (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, pOutput.Address, pOutput.Coins, pOutput.Hours);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, pOutput.Address, pOutput.Coins, pOutput.Hours);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // Output coins are 0
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (tx, 0, pOutput);
            pOutput.Coins = 0;
            err = skycoin.skycoin.SKY_coin_Transaction_ResetOutputs (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, pOutput.Address, pOutput.Coins, pOutput.Hours);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // Output coin overflow
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (tx, 0, pOutput);
            pOutput.Coins = (ulong) (ulong.MaxValue - 3e6);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, pOutput.Address, pOutput.Coins, pOutput.Hours);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ERROR);

            // Output coins are not multiples of 1e6 (valid, decimal restriction is not enforced here)
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (tx, 0, pOutput);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetOutputs (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            pOutput.Coins += 10;
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, pOutput.Address, pOutput.Coins, pOutput.Hours);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetSignatures (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var p = new cipher_PubKey ();
            s = new cipher_SecKey ();
            err = skycoin.skycoin.SKY_cipher_GenerateKeyPair (p, s);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            secKeys = new cipher_SecKeys ();
            secKeys.allocate (1);
            secKeys.setAt (0, s);
            err = skycoin.skycoin.SKY_coin_Transaction_SignInputs (tx, secKeys);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.IsTrue (pOutput.Coins % 1e6 != 0);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            // Valid
            skycoin.skycoin.makeTransaction (tx);
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (tx, 0, pOutput);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetOutputs (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, pOutput.Address, (ulong) (10e6), pOutput.Hours);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, pOutput.Address, (ulong) (1e6), pOutput.Hours);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_Verify (tx);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
        }

        [Test]
        public void TestTransactionVerifyInput () {
            // Valid
            var ux = new coin__UxOut ();
            var s = new cipher_SecKey ();
            skycoin.skycoin.makeUxOutWithSecret (ux, s);
            var tx = skycoin.skycoin.new_Transaction__Handlep ();
            skycoin.skycoin.makeTransactionFromUxOut (ux, s, tx);
            var seckeys = new coin_UxOutArray ();
            seckeys.allocate (1);
            seckeys.setAt (0, ux);
            var err = skycoin.skycoin.SKY_coin_Transaction_VerifyInput (tx, seckeys);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
        }

        [Test]
        public void TestTransactionPushInput () {
            var tx = skycoin.skycoin.new_Transaction__Handlep ();
            skycoin.skycoin.makeEmptyTransaction (tx);
            var ux = new coin__UxOut ();
            skycoin.skycoin.makeUxOut (ux);
            var sha = new cipher_SHA256 ();
            var err = skycoin.skycoin.SKY_coin_UxOut_Hash (ux, sha);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var r = skycoin.skycoin.new_GoUint16p ();
            err = skycoin.skycoin.SKY_coin_Transaction_PushInput (tx, sha, r);
            Assert.AreEqual (skycoin.skycoin.GoUint16p_value (r), 0);
            var count = skycoin.skycoin.new_Gointp ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetInputsCount (tx, count);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (skycoin.skycoin.Gointp_value (count), 1);
            var sha1 = new cipher_SHA256 ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetInputAt (tx, 0, sha1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (sha.isEqual (sha1), 1);
            err = skycoin.skycoin.SKY_coin_Transaction_ResetInputs (tx, 0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            for (int i = 0; i < short.MaxValue; i++) {
                r = skycoin.skycoin.new_GoUint16p ();
                err = skycoin.skycoin.SKY_coin_Transaction_PushInput (tx, new cipher_SHA256 (), r);
                Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            }
            skycoin.skycoin.makeUxOut (ux);
            err = skycoin.skycoin.SKY_coin_UxOut_Hash (ux, sha);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
        }

        [Test]
        public void TestTransactionPushOutput () {
            var tx = transutils.makeEmptyTransaction ();
            var a = transutils.makeAddress ();
            var err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, a, 100, 150);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var count = skycoin.skycoin.new_Gointp ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputsCount (tx, count);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (skycoin.skycoin.Gointp_value (count), 1);
            var pOut1 = new coin__TransactionOutput ();
            var pOut = new coin__TransactionOutput ();
            pOut1.Address = a;
            pOut1.Coins = 100;
            pOut1.Hours = 150;
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (tx, 0, pOut);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (pOut.isEqual (pOut1), 1);
            for (int i = 1; i < 20; i++) {
                a = transutils.makeAddress ();
                err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (tx, a, (ulong) (i * 100), (ulong) (i * 50));
                Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
                count = skycoin.skycoin.new_Gointp ();
                err = skycoin.skycoin.SKY_coin_Transaction_GetOutputsCount (tx, count);
                Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
                Assert.AreEqual (skycoin.skycoin.Gointp_value (count), (i + 1));
                pOut1 = new coin__TransactionOutput ();
                pOut = new coin__TransactionOutput ();
                pOut1.Address = a;
                pOut1.Coins = (ulong) (i * 100);
                pOut1.Hours = (ulong) (i * 50);
                err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (tx, i, pOut);
                Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
                Assert.AreEqual (pOut.isEqual (pOut1), 1);
            }
        }

        [Test]
        public void TestTransactionSignInputs () {
            var handle = transutils.makeEmptyTransaction ();
            //  Panics if txns already signed
            var sig = new cipher_Sig ();
            var err = skycoin.skycoin.SKY_coin_Transaction_PushSignature (handle, sig);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var seckeys = new cipher_SecKeys ();
            seckeys.allocate (1);
            seckeys.setAt (0, new cipher_SecKey ());
            // Panics if not enough keys
            handle = transutils.makeEmptyTransaction ();
            var s = new cipher_SecKey ();
            var s2 = new cipher_SecKey ();
            var ux = new coin__UxOut ();
            var ux2 = new coin__UxOut ();
            skycoin.skycoin.makeUxOutWithSecret (ux, s);
            var h = new cipher_SHA256 ();
            err = skycoin.skycoin.SKY_coin_UxOut_Hash (ux, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var r = skycoin.skycoin.new_GoUint16p ();
            err = skycoin.skycoin.SKY_coin_Transaction_PushInput (handle, h, r);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            skycoin.skycoin.makeUxOutWithSecret (ux2, s2);
            err = skycoin.skycoin.SKY_coin_UxOut_Hash (ux2, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_PushInput (handle, h, r);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_PushOutput (handle, transutils.makeAddress (), 40, 80);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var count = skycoin.skycoin.new_Gointp ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetSignaturesCount (handle, count);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (skycoin.skycoin.Gointp_value (count), 0);
            // Valid signing
            h = new cipher_SHA256 ();
            skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, h);
            seckeys = new cipher_SecKeys ();
            seckeys.allocate (2);
            seckeys.setAt (0, s);
            seckeys.setAt (1, s2);
            err = skycoin.skycoin.SKY_coin_Transaction_SignInputs (handle, seckeys);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_GetSignaturesCount (handle, count);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (skycoin.skycoin.Gointp_value (count), 2);
            var h2 = new cipher_SHA256 ();
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, h2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (h.isEqual (h2), 1);
            var p = new cipher_PubKey ();
            err = skycoin.skycoin.SKY_cipher_PubKeyFromSecKey (s, p);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var a = new cipher__Address ();
            var a2 = new cipher__Address ();
            err = skycoin.skycoin.SKY_cipher_AddressFromPubKey (p, a);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_PubKeyFromSecKey (s2, p);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_AddressFromPubKey (p, a2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var sha1 = new cipher_SHA256 ();
            var sha2 = new cipher_SHA256 ();
            var txin0 = new cipher_SHA256 ();
            var txin1 = new cipher_SHA256 ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetInputAt (handle, 0, txin0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_GetInputAt (handle, 1, txin1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_AddSHA256 (h, txin0, sha1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_AddSHA256 (h, txin1, sha2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var txsig0 = new cipher_Sig ();
            var txsig1 = new cipher_Sig ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetSignatureAt (handle, 0, txsig0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_GetSignatureAt (handle, 1, txsig1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_ChkSig (a, sha1, txsig0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_ChkSig (a2, sha2, txsig1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_cipher_ChkSig (a, h, txsig1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ErrInvalidAddressForSig);
            err = skycoin.skycoin.SKY_cipher_ChkSig (a2, h, txsig0);
            Assert.AreEqual (err, skycoin.skycoin.SKY_ErrInvalidAddressForSig);
        }

        [Test]
        public void TestTransactionHash () {
            var handle = skycoin.skycoin.new_Transaction__Handlep ();
            skycoin.skycoin.makeTransaction (handle);
            var h = new cipher_SHA256 ();
            var h2 = new cipher_SHA256 ();
            var err = skycoin.skycoin.SKY_coin_Transaction_Hash (handle, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (h.isEqual (h2), 0);
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, h2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (h.isEqual (h2), 0);
        }

        [Test]
        public void TestTransactionUpdateHeader () {
            var handle = skycoin.skycoin.new_Transaction__Handlep ();
            var tx = skycoin.skycoin.makeTransaction (handle);
            var h = new cipher_SHA256 ();
            var h1 = new cipher_SHA256 ();
            var h2 = new cipher_SHA256 ();
            var err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            tx.setInnerHash (new cipher_SHA256 ());
            err = skycoin.skycoin.SKY_coin_Transaction_UpdateHeader (handle);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            h1.assignFrom (tx.getInnerHash ());
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, h2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (h1.isEqual (new cipher_SHA256 ()), 0);
            Assert.AreEqual (h1.isEqual (h), 1);
            Assert.AreEqual (h1.isEqual (h2), 1);
        }

        [Test]
        public void TestTransactionHashInner () {
            var handle = skycoin.skycoin.new_Transaction__Handlep ();
            skycoin.skycoin.makeTransaction (handle);
            var h = new cipher_SHA256 ();
            var err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (h.isEqual (new cipher_SHA256 ()), 0);

            // If tx.In is changed, hash should change
            var handle2 = transutils.copyTransaction (handle);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var ux = new coin__UxOut ();
            skycoin.skycoin.makeUxOut (ux);
            h = new cipher_SHA256 ();
            var h1 = new cipher_SHA256 ();
            err = skycoin.skycoin.SKY_coin_UxOut_Hash (ux, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_SetInputAt (handle2, 0, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_UxOut_Hash (ux, h1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (h.isEqual (h1), 1);
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, h);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle2, h1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (h.isEqual (h1), 0);

            // If tx.Out is changed, hash should change
            handle2 = transutils.copyTransaction (handle);
            var a = transutils.makeAddress ();
            var pOut = new coin__TransactionOutput ();
            err = skycoin.skycoin.SKY_coin_Transaction_GetOutputAt (handle2, 0, pOut);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            pOut.Address = a;
            err = skycoin.skycoin.SKY_coin_Transaction_SetOutputAt (handle2, 0, pOut);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var sha1 = new cipher_SHA256 ();
            var sha2 = new cipher_SHA256 ();
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, sha1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle2, sha2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (sha1.isEqual (sha2), 0);

            // If tx.Head is changed, hash should not change
            handle2 = transutils.copyTransaction (handle);
            var sig = new cipher_Sig ();
            err = skycoin.skycoin.SKY_coin_Transaction_PushSignature (handle, sig);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            sha1 = new cipher_SHA256 ();
            sha2 = new cipher_SHA256 ();
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle, sha1);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            err = skycoin.skycoin.SKY_coin_Transaction_HashInner (handle2, sha2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (sha1.isEqual (sha2), 1);
        }

        [Test]
        public void TestTransactionSerialization () {
            var handle = skycoin.skycoin.new_Transaction__Handlep ();
            var tx = skycoin.skycoin.makeTransaction (handle);
            var b = new GoSlice ();
            var err = skycoin.skycoin.SKY_coin_Transaction_Serialize (handle, b);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            // var handle2 = skycoin.skycoin.new_Transaction__Handlep ();
            var handle2 = transutils.copyTransaction (handle);
            // err = skycoin.skycoin.SKY_coin_TransactionDeserialize (b, handle2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            var tx2 = new coin__Transaction ();
            err = skycoin.skycoin.SKY_coin_GetTransactionObject (handle2, tx2);
            Assert.AreEqual (err, skycoin.skycoin.SKY_OK);
            Assert.AreEqual (tx.isEqual (tx2), 0);

        }

    }
}