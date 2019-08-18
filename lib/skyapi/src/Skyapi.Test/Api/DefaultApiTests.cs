/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * The version of the OpenAPI document: 0.26.0
 * Contact: contact@skycoin.net
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;
using Skyapi.Client;
using Skyapi.Api;
using Skyapi.Model;

namespace Skyapi.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
            
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            //Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        
        /// <summary>
        /// Test AddressCount
        /// </summary>
        [Test]
        public void AddressCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AddressCount();
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test AddressUxouts
        /// </summary>
        [Test]
        public void AddressUxoutsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.AddressUxouts(address);
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
        /// <summary>
        /// Test ApiV1RawtxGet
        /// </summary>
        [Test]
        public void ApiV1RawtxGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiV1RawtxGet();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test ApiV2MetricsGet
        /// </summary>
        [Test]
        public void ApiV2MetricsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiV2MetricsGet();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test BalanceGet
        /// </summary>
        [Test]
        public void BalanceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string addrs = null;
            //var response = instance.BalanceGet(addrs);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test BalancePost
        /// </summary>
        [Test]
        public void BalancePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string addrs = null;
            //var response = instance.BalancePost(addrs);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Block
        /// </summary>
        [Test]
        public void BlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string hash = null;
            //int? seq = null;
            //var response = instance.Block(hash, seq);
            //Assert.IsInstanceOf<List<BlockSchema>> (response, "response is List<BlockSchema>");
        }
        
        /// <summary>
        /// Test BlockchainMetadata
        /// </summary>
        [Test]
        public void BlockchainMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BlockchainMetadata();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test BlockchainProgress
        /// </summary>
        [Test]
        public void BlockchainProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BlockchainProgress();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Blocks
        /// </summary>
        [Test]
        public void BlocksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? start = null;
            //int? end = null;
            //List<int?> seq = null;
            //var response = instance.Blocks(start, end, seq);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test CoinSupply
        /// </summary>
        [Test]
        public void CoinSupplyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CoinSupply();
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test Csrf
        /// </summary>
        [Test]
        public void CsrfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Csrf();
            //Assert.IsInstanceOf<InlineResponse2003> (response, "response is InlineResponse2003");
        }
        
        /// <summary>
        /// Test DataDELETE
        /// </summary>
        [Test]
        public void DataDELETETest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string key = null;
            //instance.DataDELETE(type, key);
            
        }
        
        /// <summary>
        /// Test DataGET
        /// </summary>
        [Test]
        public void DataGETTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string key = null;
            //var response = instance.DataGET(type, key);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DataPOST
        /// </summary>
        [Test]
        public void DataPOSTTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string type = null;
            //string key = null;
            //string val = null;
            //instance.DataPOST(type, key, val);
            
        }
        
        /// <summary>
        /// Test DefaultConnections
        /// </summary>
        [Test]
        public void DefaultConnectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DefaultConnections();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test Health
        /// </summary>
        [Test]
        public void HealthTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Health();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test LastBlocks
        /// </summary>
        [Test]
        public void LastBlocksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? num = null;
            //var response = instance.LastBlocks(num);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test NetworkConnection
        /// </summary>
        [Test]
        public void NetworkConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string addr = null;
            //var response = instance.NetworkConnection(addr);
            //Assert.IsInstanceOf<NetworkConnectionSchema> (response, "response is NetworkConnectionSchema");
        }
        
        /// <summary>
        /// Test NetworkConnections
        /// </summary>
        [Test]
        public void NetworkConnectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string states = null;
            //string direction = null;
            //var response = instance.NetworkConnections(states, direction);
            //Assert.IsInstanceOf<InlineResponse2004> (response, "response is InlineResponse2004");
        }
        
        /// <summary>
        /// Test NetworkConnectionsDisconnect
        /// </summary>
        [Test]
        public void NetworkConnectionsDisconnectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.NetworkConnectionsDisconnect(id);
            
        }
        
        /// <summary>
        /// Test NetworkConnectionsExchange
        /// </summary>
        [Test]
        public void NetworkConnectionsExchangeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.NetworkConnectionsExchange();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test NetworkConnectionsTrust
        /// </summary>
        [Test]
        public void NetworkConnectionsTrustTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.NetworkConnectionsTrust();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test OutputsGet
        /// </summary>
        [Test]
        public void OutputsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> address = null;
            //List<string> hash = null;
            //var response = instance.OutputsGet(address, hash);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OutputsPost
        /// </summary>
        [Test]
        public void OutputsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string hash = null;
            //var response = instance.OutputsPost(address, hash);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test PendingTxs
        /// </summary>
        [Test]
        public void PendingTxsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.PendingTxs();
            //Assert.IsInstanceOf<List<InlineResponse20010>> (response, "response is List<InlineResponse20010>");
        }
        
        /// <summary>
        /// Test ResendUnconfirmedTxns
        /// </summary>
        [Test]
        public void ResendUnconfirmedTxnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ResendUnconfirmedTxns();
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Richlist
        /// </summary>
        [Test]
        public void RichlistTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? includeDistribution = null;
            //string n = null;
            //var response = instance.Richlist(includeDistribution, n);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Transaction
        /// </summary>
        [Test]
        public void TransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string txid = null;
            //var response = instance.Transaction(txid);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test TransactionInject
        /// </summary>
        [Test]
        public void TransactionInjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rawtx = null;
            //var response = instance.TransactionInject(rawtx);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test TransactionPost
        /// </summary>
        [Test]
        public void TransactionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TransactionV2ParamsAddress transactionV2ParamsAddress = null;
            //var response = instance.TransactionPost(transactionV2ParamsAddress);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test TransactionPostUnspent
        /// </summary>
        [Test]
        public void TransactionPostUnspentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TransactionV2ParamsUnspent transactionV2ParamsUnspent = null;
            //var response = instance.TransactionPostUnspent(transactionV2ParamsUnspent);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test TransactionRaw
        /// </summary>
        [Test]
        public void TransactionRawTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string txid = null;
            //var response = instance.TransactionRaw(txid);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TransactionVerify
        /// </summary>
        [Test]
        public void TransactionVerifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TransactionVerifyRequest transactionVerifyRequest = null;
            //var response = instance.TransactionVerify(transactionVerifyRequest);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TransactionsGet
        /// </summary>
        [Test]
        public void TransactionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string addrs = null;
            //string confirmed = null;
            //var response = instance.TransactionsGet(addrs, confirmed);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TransactionsPost
        /// </summary>
        [Test]
        public void TransactionsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string addrs = null;
            //string confirmed = null;
            //var response = instance.TransactionsPost(addrs, confirmed);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Uxout
        /// </summary>
        [Test]
        public void UxoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string uxid = null;
            //var response = instance.Uxout(uxid);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test VerifyAddress
        /// </summary>
        [Test]
        public void VerifyAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object address = null;
            //var response = instance.VerifyAddress(address);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test Version
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Version();
            //Assert.IsInstanceOf<InlineResponse2005> (response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test Wallet
        /// </summary>
        [Test]
        public void WalletTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.Wallet(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletBalance
        /// </summary>
        [Test]
        public void WalletBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.WalletBalance(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletCreate
        /// </summary>
        [Test]
        public void WalletCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string seed = null;
            //string label = null;
            //int? scan = null;
            //bool? encrypt = null;
            //string password = null;
            //var response = instance.WalletCreate(seed, label, scan, encrypt, password);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletDecrypt
        /// </summary>
        [Test]
        public void WalletDecryptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string password = null;
            //var response = instance.WalletDecrypt(id, password);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletEncrypt
        /// </summary>
        [Test]
        public void WalletEncryptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string password = null;
            //var response = instance.WalletEncrypt(id, password);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletFolder
        /// </summary>
        [Test]
        public void WalletFolderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string addr = null;
            //var response = instance.WalletFolder(addr);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test WalletNewAddress
        /// </summary>
        [Test]
        public void WalletNewAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string num = null;
            //string password = null;
            //var response = instance.WalletNewAddress(id, num, password);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletNewSeed
        /// </summary>
        [Test]
        public void WalletNewSeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entropy = null;
            //var response = instance.WalletNewSeed(entropy);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletRecover
        /// </summary>
        [Test]
        public void WalletRecoverTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string seed = null;
            //string password = null;
            //var response = instance.WalletRecover(id, seed, password);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletSeed
        /// </summary>
        [Test]
        public void WalletSeedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string password = null;
            //var response = instance.WalletSeed(id, password);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletSeedVerify
        /// </summary>
        [Test]
        public void WalletSeedVerifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string seed = null;
            //var response = instance.WalletSeedVerify(seed);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletTransaction
        /// </summary>
        [Test]
        public void WalletTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WalletTransactionRequest walletTransactionRequest = null;
            //var response = instance.WalletTransaction(walletTransactionRequest);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WalletTransactionSign
        /// </summary>
        [Test]
        public void WalletTransactionSignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WalletTransactionSignRequest walletTransactionSignRequest = null;
            //var response = instance.WalletTransactionSign(walletTransactionSignRequest);
            //Assert.IsInstanceOf<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test WalletTransactions
        /// </summary>
        [Test]
        public void WalletTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.WalletTransactions(id);
            //Assert.IsInstanceOf<InlineResponse2006> (response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test WalletUnload
        /// </summary>
        [Test]
        public void WalletUnloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.WalletUnload(id);
            
        }
        
        /// <summary>
        /// Test WalletUpdate
        /// </summary>
        [Test]
        public void WalletUpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string label = null;
            //var response = instance.WalletUpdate(id, label);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test Wallets
        /// </summary>
        [Test]
        public void WalletsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Wallets();
            //Assert.IsInstanceOf<List<Object>> (response, "response is List<Object>");
        }
        
    }

}
