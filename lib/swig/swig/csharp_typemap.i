%include "arrays_csharp.i"
%include cpointer.i
%pointer_functions(GoSlice, GoSlicep);
%pointer_functions(GoUint8_, GoUint8Ptr);
%pointer_functions(_GoString_, GoStringp);
%pointer_functions(int, intp);
%pointer_functions( unsigned int, GoUint32Ptr);
%pointer_functions(coin__Transaction, coin__Transactionp);
%pointer_functions(AddressUxOuts_Handle, AddressUxOuts__HandlePtr);
%pointer_functions(unsigned long long, GoUint64p);
%pointer_functions(long long, Gointp);
%pointer_functions(unsigned short, GoUint16p);
%pointer_functions(cipher__Address, cipher__Addressp);
%pointer_functions(Transactions__Handle, Transactions__HandlePtr);
%pointer_functions(Transaction__Handle, Transaction__Handlep);
%pointer_functions(Block__Handle,Block__HandlePtr);
%pointer_functions(BlockBody__Handle,BlockBody__HandlePtr);
%pointer_functions(BlockHeader__Handle,BlockHeader__HandlePtr);
%pointer_functions(Signature_Handle,Signature_HandlePtr);
%pointer_functions(Number_Handle,Number_HandlePtr);
%pointer_functions(unsigned char, CharPtr);
%pointer_functions(FeeCalculator, FeeCalculatorPtr);
%pointer_functions(FeeCalcFunc, FeeCalcFuncPtr);
%pointer_functions(coin__Block*, coin__BlockPtr);

/*GoString* parameter as reference */
%typemap(in, numinputs=0) GoString* (GoString temp) {
	temp.p = NULL;
	temp.n = 0;
	$1 = ($1_type)&temp;
}

/**
* Import library
**/
%include "typemaps.i"
// Pubkey
%typemap(ctype,pre="cipher_PubKey tmp$csinput = new_cipher_PubKeyp();") (GoUint8_ (*) [33])  "cipher__PubKey*"
%typemap(cstype,pre="var tmp$csinput = cipher_PubKey.getCPtr ($csinput);") (GoUint8_ (*) [33])  "cipher_PubKey"
%typemap(csin,pre="var tmp$csinput = cipher_PubKey.getCPtr ($csinput);") (GoUint8_ (*) [33])  "tmp$csinput"


// Seckey
%typemap(ctype,pre="cipher_SecKey tmp$csinput = new_cipher_SecKeyp();") (GoUint8_ (*) [32])  "cipher_SecKey*"
%typemap(cstype,pre=" var tmp$csinput = cipher_SecKey.getCPtr ($csinput);") (GoUint8_ (*) [32])  "cipher_SecKey"
%typemap(csin,pre="var tmp$csinput = cipher_SecKey.getCPtr ($csinput);") (GoUint8_ (*) [32])  "tmp$csinput"

// Sig
%typemap(ctype,pre="cipher_Sig tmp$csinput = new cipher_Sig();") (GoUint8_ (*) [65])  "cipher_Sig*"
%typemap(cstype,pre=" var tmp$csinput = cipher_Sig.getCPtr ($csinput);") (GoUint8_ (*) [65])  "cipher_Sig"
%typemap(csin,pre="var tmp$csinput = cipher_Sig.getCPtr ($csinput);") (GoUint8_ (*) [65])  "tmp$csinput"

// cipher__Ripemd160
%typemap(ctype,pre="cipher__Ripemd160 tmp$csinput = new_cipher_Ripemd160p();") (GoUint8_ (*) [20])  "cipher_Ripemd160*"
%typemap(cstype,pre=" var tmp$csinput = cipher_Ripemd160.getCPtr ($csinput);") (GoUint8_ (*) [20])  "cipher_Ripemd160"
%typemap(csin,pre="var tmp$csinput = cipher_Ripemd160.getCPtr ($csinput);") (GoUint8_ (*) [20])  "tmp$csinput"


// GoString
%typemap(cstype,pre=" var tmp$csinput = $csinput;") GoString "string"
%typemap(csin,pre="var tmp$csinput = $csinput;") GoString  "tmp$csinput"
%typemap(imtype,pre="var tmp$csinput  = $csinput;") GoString  "string"
%typemap(ctype) GoString  "char*"
%typemap(in) GoString  "$1.p=$input;$1.n=strlen($input);"

%typemap(ctype,pre="GoString_ tmp$csinput = new_GoStringp_();") GoString_*  "GoString*"
%typemap(cstype,pre=" var tmp$csinput = _GoString_.getCPtr ($csinput);") GoString_*  "_GoString_"
%typemap(csin,pre="var tmp$csinput = _GoString_.getCPtr ($csinput);") GoString_*  "tmp$csinput"

// GoSlice
%typemap(ctype) GoSlice_*  "GoSlice_ *"
%typemap(cstype,pre=" var tmp$csinput = GoSlice.getCPtr ($csinput);") GoSlice_*  "GoSlice"
%typemap(csin) GoSlice_*  "GoSlice.getCPtr ($csinput)"

%typemap(freearg) (cipher_PubKeys* __in_pubKeys) {
  if ($1->data) free($1->data);
}

