using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using DfcuTester.dfcu;
//using APIDEncrypt;

namespace DfcuTester
{
    class Program
    {
       static void Main(string[] args)
        {
            Encryption p = new Encryption();
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string date1 = DateTime.Now.ToString("dd-MMM-y");
            
           FINAPI.webserviceSoapClient finclient = new FINAPI.webserviceSoapClient();

            ////FINSERVICE URA INQUIRE
            //string utilityCode = "000";
            //string utilityArea = "";
            //string custRef = "2200001785928";//2200000004931
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //////FINSERVICE MUTESA INQUIRE
            //string utilityCode = "MUTESA";
            //string utilityArea = "";
            //string custRef = "1500201831";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE NWSC INQUIRE
            //string utilityCode = "002";
            //string utilityArea = "KAMPALA";
            //string custRef = "2170065";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            ////FINSERVICE ZEEPAY INQUIRE
            //string utilityCode = "ZEEPAY";
            //string utilityArea = "";
            //string custRef = "8BC2B5EAC2A48";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE AIRTEL FLOAT DEPOSIT INQUIRE
            string utilityCode = "AIRTELFLTDEP";
            string utilityArea = "";
            string custRef = "707526984";
            string ApiUsername = "FINWEB";
            string ApiPassword = "A!@##*9900K";

            //FINSERVICE TUCKSEE INQUIRE
            //string utilityCode = "TUCKSEE";
            //string utilityArea = "";
            //string custRef = "H2PBR19000000034";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE MTN INQUIRE
            //string utilityCode = "MTN";
            //string utilityArea = "";
            //string custRef = "256789608735";//256789608735    
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE ICLUB INQUIRE
            //string utilityCode = "ICLUBL";
            //string utilityArea = "01061112536712";
            //string custRef = "256775323713";//256789608735  256774694495  
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE MUTESA INQUIRE
            //string utilityCode = "MUTESA";
            //string utilityArea = "01061112536712";
            //string custRef = "256775323713";//256789608735  256774694495  
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            ////FINSERVICE IIU INQUIRE
            //string utilityCode = "IIU";
            //string utilityArea = "";
            //string custRef = "2018113015235875544";//2018113015235875544
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE UMEME INQUIRE
            //string utilityCode = "001";
            //string utilityArea = "";
            //string custRef = "04253657003";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            ////FINSERVICE PEBU INQUIRE
            //string utilityCode = "PEBU";
            //string utilityArea = "";
            //string custRef = "0792023234";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE URA INQUIRE - OLD API GATEWAY IMPLEMENTATION
            //string utilityCode = "000";
            //string utilityArea = "";
            //string custRef = "2190000007410";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //FINSERVICE SPAY INQUIRE
            //string utilityCode = "SPAY";
            //string utilityArea = "20000";
            //string custRef = "1000156193";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            ////FINSERVICE PAYWAY INQUIRE
            //string utilityCode = "PAYWAY";
            //string utilityArea = "";
            //string custRef = "0187";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            ////FINSERVICE DSTV INQUIRE
            //string utilityCode = "DSTVPROD";
            //string utilityArea = "";
            //string custRef = "DSTV";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";


            ////////FINSERVICE NSSF INQUIRE
            ////string utilityCode = "NSSF";
            ////string utilityArea = "";
            ////string custRef = "DFCU788372";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            ////string ApiUsername = "FINWEB";
            ////string ApiPassword = "A!@##*9900K";

            //FINSERVICE UEDCL INQUIRE
            //string utilityCode = "UEDCL";
            //string phone = "";
            //string custRef = "04040404255";//2018113015235875544  //E22030312151954 E22030312159226 P10000310072735 P10000310072736 Other Payment Types
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string utilityArea = phone;

            string result = finclient.InquireUtility(utilityCode, utilityArea, custRef, ApiUsername, ApiPassword);

            //FINSERVICE NWSC NOTIFY
            //string strUtilityCode = "002";
            //string strcustomerRef = "21117391";
            //string strcustomerArea = "kampala";
            //string strphone = "0779653858";
            //string strdate = "21/11/2018";
            //string amount = "4000";
            //string mtd = "CASH";
            //string reference = "14526736565341";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "", reserve2 = "", reserve3 = "", reserve4 = "", reserve5 = "";

            ////FINSERVICE URA NOTIFY
            //string strUtilityCode = "000";
            //string strcustomerRef = "2200000842701";
            ////string payerName = "Benjamin Bwambale";
            //string strcustomerArea = "";
            //string strphone = "";
            //string amount = "50000";
            //string reference = "URA_2200000842701_245";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "C", reserve2 = "", reserve3 = "", reserve4 = "", reserve5 = "";

            // FINSERVICE URA NOTIFY --OLD APIGATEWAY IMPLEMENTATION
            //string strUtilityCode = "000";
            //string strcustomerRef = "2190000007410";
            //string payerName = "Amwine Patrick";
            //string strcustomerArea = payerName;
            //string strphone = "0779653858";
            //string amount = "56000";
            //string reference = "7875094URA762";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "A", reserve2 = "", reserve3 = "", reserve4 = "", reserve5 = "";

            //FINSERVICE ICLUB NOTIFY

            //string strUtilityCode = "ICLUB";
            //string strcustomerRef = "256775323713";
            //string strcustomerArea = "";
            //string strphone = "256775323713";
            //string strdate = DateTime.Now.ToString();
            //string amount = "7000";
            //string reference = "HJT-HSMDN_237834";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "01061112536712"; //Club Account
            //string reserve2 = "2567100002431"; //Loan Account
            //string reserve3 = "PAMWINE";//Teller Id 
            //string reserve4 = "DEPOSIT"; //Identifier for Payment Type ==> DEPOSIT | LOAN
            //string reserve5 = "";

            //FINSERVICE MUTESA PAYMENT NOTIFY
            //string strUtilityCode = "MUTESA";
            //string strcustomerRef = "1500201831";
            //string strcustomerArea = "";
            //string strphone = "256772187533";
            //string strdate = DateTime.Now.ToString();
            //string amount = "70000";
            //string reference = "DREF587629";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = ""; //CheqNo
            //string reserve2 = "1"; //Semester
            //string reserve3 = "3";//Yearofstudy 
            //string reserve4 = "";
            //string reserve5 = "";

            //FINSERVICE TUCKSEE PAYMENT NOTIFY
            //string strUtilityCode = "TUCKSEE";
            //string strcustomerRef = "H2PBR19000000026";
            //string strcustomerArea = "";
            //string strphone = "256772187533";
            //string strdate = DateTime.Now.ToString();
            //string amount = "70000";
            //string reference = "6845_TUCKSEE_123";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "83A13CED945A4D889DB1DCC5B74A7ED4"; //TpgoReference
            //string reserve2 = "12a12ef7a8ce622fd8fc0d116e23d547"; //Session Key
            //string reserve3 = "";//Yearofstudy 
            //string reserve4 = "";
            //string reserve5 = "";

            //FINSERVICE SPAY PAYMENT NOTIFY
            //string strUtilityCode = "SPAY";
            //string strcustomerRef = "1000026383";
            //string strcustomerArea = "";
            //string strphone = "0779653858";
            //string amount = "70000";
            //string reference = "SPAY_1000026383_32558";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "36 KYADONDO"; //Branch
            //string reserve2 = "SNANKUNDA"; //Teller ID
            //string reserve3 = "0";//Partial Allowed 
            //string reserve4 = "AMWINE PATRICK";//Depositor Name
            //string reserve5 = "STUDENT NAMES";

            ////FINSERVICE UEDCL PAYMENT NOTIFY
            //string strUtilityCode = "UEDCL";
            //string strcustomerRef = "04040404255";
            //string strcustomerArea = "";
            //string strphone = "0779653858";
            //string amount = "70000";
            //string reference = "UBPAY_04040404255_73295";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "2";
            //string reserve1 = paymentType; 
            //string reserve2 = "";
            //string reserve3 = "";
            //string reserve4 = "";
            //string reserve5 = "";

            ////FINSERVICE PAYWAY PAYMENT NOTIFY
            //string strUtilityCode = "PAYWAY";
            //string strcustomerRef = "0186";
            //string strcustomerArea = "";
            //string strphone = "0779653858";
            //string amount = "70000";
            //string reference = "PAYWAY_0186_4733485";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "";
            //string reserve2 = "";
            //string reserve3 = "";
            //string reserve4 = "";
            //string reserve5 = "";

            ////FINSERVICE NSSF PAYMENT NOTIFY
            //string strUtilityCode = "NSSF";
            //string strcustomerRef = "DFCU710394";
            //string strcustomerArea = "";
            //string strphone = "";
            //string amount = "60000";
            //string reference = "NSSF_0186_4733485";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "";
            //string reserve2 = "";
            //string reserve3 = "";
            //string reserve4 = "";
            //string reserve5 = "";


            //string result2 = finclient.PostUtilityTransaction(strUtilityCode, strcustomerArea, strcustomerRef, ApiUsername, ApiPassword, strphone, amount, reference, paymentType, reserve1, reserve2, reserve3, reserve4, reserve5);

            ////string input = "HAHAHA";
            //string result = finclient.postToMWare(input);

            //////FINSERVICE UMEME NOTIFY - OLD OFF THE API GATEWAY
            //string strUtilityCode = "001";
            //string strcustomerRef = "04240215527";  //PrePaid 04217269374  04240215527 | PostPaid 200166426  200161188  200086202
            //string strcustomerArea = "PREPAID";
            //string strphone = "0779653858";
            //string amount = "10000";
            //string reference = "HHDJH847JHH";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "2";
            //string reserve1 = "", reserve2 = "", reserve3 = "", reserve4 = "", reserve5 = "";

            ////FINSERVICE UMEME NOTIFY - NEW AND CURRENT
            //string strUtilityCode = "001";
            //string strcustomerRef = "04240215527";  //PrePaid 04217269374  04240215527 | PostPaid 200166426  200161188  200086202
            //string strcustomerArea = "PREPAID";
            //string strphone = "0779653858";
            //string amount = "10000";
            //string reference = "UME_23495_2453";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "2";
            //string reserve1 = "AMWINE PATRICK", reserve2 = "", reserve3 = "", reserve4 = "", reserve5 = "";

            //string result = finclient.PostUtilityTransaction(strUtilityCode, strcustomerArea, strcustomerRef, ApiUsername, ApiPassword, strphone, amount, reference, paymentType, reserve1, reserve2, reserve3, reserve4, reserve5);


            //////FINSERVICE PEBU NOTIFY
            //string strUtilityCode = "PEBU";
            //string strcustomerRef = "0792023234";  //PrePaid 04217269374  04240215527 | PostPaid 200166426  200161188  200086202
            //string strcustomerArea = "20190314133049";//Pass the TransactionId Here for PEBU
            //string strphone = "";
            //string amount = "10000";
            //string reference = "HYD_PEBU_342";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";
            //string paymentType = "";
            //string reserve1 = "", reserve2 = "", reserve3 = "", reserve4 = "", reserve5 = "";

            //string result = finclient.PostUtilityTransaction(strUtilityCode, strcustomerArea, strcustomerRef, ApiUsername, ApiPassword, strphone, amount, reference, paymentType, reserve1, reserve2, reserve3, reserve4, reserve5);



            ////////FINSERVICE IIU NOTIFY
            //string strUtilityCode = "IIU";
            //string strcustomerRef = "2018090511124913334";  //
            //string strphone = "0779653858";
            //string amount = "50000";
            //string reference = "dfgsbbk34565njdf";
            //string studyYear = "2";
            //string studySem = "2";
            //string ApiUsername = "FINWEB";
            //string ApiPassword = "A!@##*9900K";

            //string result = finclient.PostIUIUTransaction(strUtilityCode, studyYear, studySem, strcustomerRef, ApiUsername, ApiPassword, strphone, amount, reference);

            Console.ReadLine();
        }

        //validate  dfcu accounts
        public static void ValidateDFCUaccounts()
        {

            var samples = new List<esb.ValidAgencyReqz>();
            var p = new esb.ValidAgencyReqz();
            esb.webapi method = new esb.webapi();

            string strUtilityCode = "AGVAL";
            string stracctid = "01017015986431";
            string strVendorCode = "ebankitapp";
            string strAgentID = "289264";
            string strVendorPassword = "D7@n0!@80o2";
            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";


            string strSignature = null;
            strSignature = strUtilityCode.Trim() + stracctid.Trim() + strAgentID.Trim() +  strVendorCode.Trim() + strVendorPassword.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];
            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);
            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);

            esb.ValidAgencyQuery txn = new esb.ValidAgencyQuery
            {
                strUtilityCode = strUtilityCode,//"AGDEP",
                stracctid = stracctid,//"10020452421",
                strusr = strVendorCode,//"ebankitapp",
                strpwd = strVendorPassword,//"D7@n0!@80o2",
                strAgentID = strAgentID,//"289264",
                strsignature = strConvertedSignature
            };
            p.validagencyquery = txn;
            samples.Add(p);
            esb.AgencyCustDetailz[] ds = method.ValidateAgencyCustDetails(samples.ToArray());

        }

        //validate non dfcu accounts
        public static void ValidateABCaccounts()
        {
            
            esb.ValidAgencyQueryNOND api = new esb.ValidAgencyQueryNOND();
            var samples = new List<esb.ValidAgencyReqz>();
            var p = new esb.ValidAgencyReqz();
            esb.webapi method = new esb.webapi();

            string strUtilityCode = "AGVALNOND";
            string stracctid = "6000013399";//"0357056222001";
            string strBankscode = "013847";// "190147";
            string strVendorCode = "ebankitapp";
            string strAgentID = "289264";
            string strVendorPassword = "D7@n0!@80o2";
            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";
           

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + stracctid.Trim() + strAgentID.Trim() + strBankscode.Trim() + strVendorCode.Trim() + strVendorPassword.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);

            //esb.ValidpostAgencyDepositTran txn = new esb.ValidpostAgencyDepositTran
            esb.ValidAgencyQueryNOND txn = new esb.ValidAgencyQueryNOND
            {
                strUtilityCode = strUtilityCode,//"AGDEP",
                stracctid =  stracctid,//"10020452421",
                strBankscode = strBankscode,//"020147",
                strusr = strVendorCode,//"ebankitapp",
                strpwd = strVendorPassword,//"D7@n0!@80o2",
                strAgentID = strAgentID,//"289264",
                strsignature = strConvertedSignature
            };
            p.validagencyquerynOnd = txn; 
            samples.Add(p);
            esb.AgencyCustDetailz[] ds = method.ValidateAgencyCustDetails(samples.ToArray());

        }
      
        //validate dfcu accounts
        public static void PostAgencyBankingDeposit()
        {
            esbgateway.ValidpostAgencyDepositTran api = new esbgateway.ValidpostAgencyDepositTran();
            var samples = new List<esb.ValidpostAgencyBanktranz>();
            var p = new esb.ValidpostAgencyBanktranz();

            esb.webapi method = new esb.webapi();

            string strUtilityCode = "003";
            string strCustomerRef = "4623662097";//"10459441720";
            string strVendorCode = "eutilitiesapp";
            string strVendorPassword = "D7@n0!@80o2";

            string stBankCertLocation = @"E:\pbucert\dfcubank.pfx";
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            //(strUtilityCode + strCustomerRef + strCustArea + strVendorCode + strVendorPassword)
            strSignature = strUtilityCode.Trim() + strCustomerRef.Trim() + strVendorCode.Trim() + strVendorPassword.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);

            esb.ValidpostAgencyDepositTran txn = new esb.ValidpostAgencyDepositTran
            {
                strUtilityCode = "AGDEP",
                stracct_id = "01017004505938",
                strCustPhone = "0704182361",
                dtTxnDate = "04/10/2018",
                dblAmount = "10000",
                strnarration = "CASH DEPOSIT",
                strTxnRef = "20180816040419",
                strAgentID = "289264",
                strVendorCode = "ebankitapp",
                strVendorPassword = "D7@n0!@80o2",
                strsignature = strConvertedSignature
            };
            p.validpostagencydepositTran = txn;
            samples.Add(p);
            esb.TxnResultzAgencyBank[] ds = method.PostAgencyCustTransaction(samples.ToArray());

        }        
        public static string EncryptedData(string PlainStringToEncrypt, string param1)
        {
            string base64String;

            try
            {
                //string param1 = @"D:\pubcert\ebankitapp\publicKey.cer";
                X509Certificate2 x509Cert_2 = new X509Certificate2(param1);

                if (x509Cert_2 == null)
                {
                    throw new Exception("Certificate x509Cert_2 can not be null");
                }

                string str = PlainStringToEncrypt.Trim();
                byte[] bytes = Encoding.ASCII.GetBytes(str);

                RSACryptoServiceProvider key = (RSACryptoServiceProvider)x509Cert_2.PublicKey.Key;

                base64String = Convert.ToBase64String(key.Encrypt(bytes, false));
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return base64String;
        }
       
        //post OTHER BANKS
        public static void PostABC()
        {
           
            var amps = new List<esb.ValidpostAgencyBanktranz>();
            var r = new esb.ValidpostAgencyBanktranz();
            
            esb.webapi method = new esb.webapi();
            
            string encParam = @"E:\pbucert\testcerts\dfcugroup.cer";//"CN = emilius-PC"; --  ---CN= dfcubank
            string stracct_id = EncryptedData("10020452421", encParam);//GetSHA1HashData("01013505079388");//Enc.EncryptedDataSHA1("01013505079388", encParam);
            string strBanksortcode = EncryptedData("020147", encParam);//GetSHA1HashData("013847");
          string strTxnRef = EncryptedData("123456789", encParam);//GetSHA1HashData("1234567");
          string strUtilityCode = "AGDEP";
          string strCustPhone = "0704182361";
          string strnarration = "TestTransaction";
          string strVendorCode = EncryptedData("ebankitapp", encParam);//GetSHA1HashData("ebankitapp");
          string strVendorPassword = EncryptedData("D7@n0!@80o2", encParam);//GetSHA1HashData("D7@n0!@80o2");
          string dblAmount = EncryptedData("10000", encParam);//GetSHA1HashData("10000");
          string dtTxnDate = "12/11/2018";
          string strAgentID = EncryptedData("289264", encParam);//GetSHA1HashData("289264");


            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";
           
            
            


            string strSignature = null;
            strSignature = strUtilityCode.Trim() + stracct_id.Trim() + strCustPhone.Trim() + dtTxnDate.Trim() + dblAmount.Trim() + strnarration.Trim() + strBanksortcode.Trim() + strTxnRef.Trim() + strAgentID.Trim() + strVendorCode.Trim() + strVendorPassword.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
           
            esb.ValidpostAgencyDepositTranNonD abc = new esb.ValidpostAgencyDepositTranNonD
            {
                strUtilityCode = "AGDEP",
                stracct_id = stracct_id,//"01013505079388",
                strBanksortcode = strBanksortcode,//"013847",
                strCustPhone = "0704182361",
                strnarration = "TestTransaction",
                strTxnRef = strTxnRef,//"1234567",
                strVendorCode = strVendorCode,//"ebankitapp",
                strVendorPassword = strVendorPassword,//"D7@n0!@80o2",
                dblAmount = dblAmount,//"10000",
                dtTxnDate = dtTxnDate,//"31/10/2018", 
                strAgentID = strAgentID,//"289264",
                strsignature = strConvertedSignature,
                
            };
            r.validpostAgencyDepositTranNonD = abc;
            amps.Add(r);
            esb.TxnResultzAgencyBank[] dt = method.PostAgencyCustTransaction(amps.ToArray());
        }

        //post ABC
        public static void PostingABC()
        {
            var amps = new List<esb.ValidpostAgencyBanktranz>();
            var r = new esb.ValidpostAgencyBanktranz();

            esb.webapi method = new esb.webapi();
            string encParam = @"E:\pbucert\testcerts\dfcugroup.cer";//"CN = emilius-PC"; --  ---CN= dfcubank
            string stracct_id = EncryptedData("01017002769392", encParam);//GetSHA1HashData("01013505079388");//Enc.EncryptedDataSHA1("01013505079388", encParam);
           // string strBanksortcode = EncryptedData("190147", encParam);//GetSHA1HashData("013847");
            string strTxnRef = EncryptedData("12345678", encParam);//GetSHA1HashData("1234567");
            string strUtilityCode = "AGDEP";
            string strCustPhone = "0704182361";
            string strnarration = "TestTransaction";
            string strVendorCode = EncryptedData("ebankitapp", encParam);//GetSHA1HashData("ebankitapp");
            string strVendorPassword = EncryptedData("D7@n0!@80o2", encParam);//GetSHA1HashData("D7@n0!@80o2");
            string dblAmount = EncryptedData("10000", encParam);//GetSHA1HashData("10000");
            string dtTxnDate = "31/10/2018";
            string strAgentID = EncryptedData("289264", encParam);//GetSHA1HashData("289264");
            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";
            
            string strSignature = null;
            strSignature = strUtilityCode.Trim() + stracct_id.Trim() + strCustPhone.Trim() + dtTxnDate.Trim() + dblAmount.Trim() + strnarration.Trim() + strTxnRef.Trim() + strAgentID.Trim() + strVendorCode.Trim() + strVendorPassword.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);

            //esb.ValidpostAgencyDepositTranNonD abc = new esb.ValidpostAgencyDepositTranNonD
            esb.ValidpostAgencyDepositTran abc = new esb.ValidpostAgencyDepositTran
            {
                strUtilityCode = "AGDEP",
                stracct_id = stracct_id,//"01013505079388",
                strCustPhone = "0704182361",
                strnarration = "TestTransaction",
                strTxnRef = strTxnRef,//"1234567",
                strVendorCode = strVendorCode,//"ebankitapp",
                strVendorPassword = strVendorPassword,//"D7@n0!@80o2",
                dblAmount = dblAmount,//"10000",
                dtTxnDate = "31/10/2018",
                strAgentID = strAgentID,//"289264",
                strsignature = strConvertedSignature,

            };
            r.validpostagencydepositTran = abc;
            amps.Add(r);
            esb.TxnResultzAgencyBank[] dt = method.PostAgencyCustTransaction(amps.ToArray());
        }

        //dstv
        public static void TestValidateDSTV()
        {
            try
            {

                esbgateway.ValidcustDSTV api = new DfcuTester.esbgateway.ValidcustDSTV();

                api.strUtilityCode = "003";
                api.strCustomerRef = "10459441720";
                api.strVendorCode = "eutilitiesapp";
                api.strVendorPassword = "D7@n0!@80o2";
                api.strsignature = api.strUtilityCode + api.strCustomerRef + api.strVendorCode + api.strVendorPassword;


            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public static void TestValidateSchoolPay()
        {
            try
            {

                esb.ValidSchoolpayStudentQuery customer = new esb.ValidSchoolpayStudentQuery();
                esb.webapi apiInst = new esb.webapi();
                
                var custDetailInqList = new List<esb.ValidcustReqz>();
                var custDetailResList = new List<esb.CustomerDetailz>();

                esb.ValidcustReqz custListItem = new esb.ValidcustReqz();

                esb.ValidSchoolpayStudentQuery cust = new esb.ValidSchoolpayStudentQuery();

                cust.stramount = 0;
                cust.strpwd = "D7@n0!@80o2";
                cust.strrequestid = "sdfsre3645dfsh";
                cust.strsignature = "";
                cust.strstudentpaymentcode = "1000026383";
                cust.strusr = "ebankitapp";
                cust.strUtilityCode = "016";
                
                string stBankCertLocation = @"D:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
                string strBankCertPass = "DfcuBank1!";

                string strSignature = null;

                strSignature = cust.strUtilityCode.Trim() + cust.strrequestid.Trim() + cust.stramount + cust.strstudentpaymentcode.Trim() + cust.strusr.Trim() + cust.strpwd.Trim();

                X509Certificate2 x509Cert_bnk = new X509Certificate2();
                X509Certificate2Collection xer = new X509Certificate2Collection();
                X509Certificate2 xer2 = new X509Certificate2();
                xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
                xer2 = xer[0];

                RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
                byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

                byte[] signature = privateKey.SignData(buffer, "SHA1");

                //signature()
                cust.strsignature = Convert.ToBase64String(signature);

                custListItem.validschoolpaystudentquery = cust;
                custDetailInqList.Add(custListItem);
                
                esb.CustomerDetailz [] custResp = apiInst.ValidateCustomerDetails(custDetailInqList.ToArray());

                
                

            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public static void TestValidateUMEME()
        {
            try
            {

                esb.ValidcustUmemeUEDCL customer = new esb.ValidcustUmemeUEDCL();
                esb.webapi apiInst = new esb.webapi();

                var custDetailInqList = new List<esb.ValidcustReqz>();
                var custDetailResList = new List<esb.CustomerDetailz>();

                esb.ValidcustReqz custListItem = new esb.ValidcustReqz();

                esb.ValidcustUmemeUEDCL cust = new esb.ValidcustUmemeUEDCL();

                cust.strCustomerRef = "04240215527";
                cust.strsignature = "";
                cust.strUtilityCode = "001";
                cust.strVendorCode = "ebankitapp";
                cust.strVendorPassword = "D7@n0!@80o2";
                
                string stBankCertLocation = @"D:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
                string strBankCertPass = "DfcuBank1!";

                string strSignature = null;

                strSignature = cust.strUtilityCode.Trim() + cust.strCustomerRef.Trim() + cust.strVendorCode + cust.strVendorPassword.Trim();

                X509Certificate2 x509Cert_bnk = new X509Certificate2();
                X509Certificate2Collection xer = new X509Certificate2Collection();
                X509Certificate2 xer2 = new X509Certificate2();
                xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
                xer2 = xer[0];

                RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
                byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

                byte[] signature = privateKey.SignData(buffer, "SHA1");

                //signature()
                cust.strsignature = Convert.ToBase64String(signature);

                custListItem.validcustUmemeUEDCL = cust;
                custDetailInqList.Add(custListItem);

                esb.CustomerDetailz[] custResp = apiInst.ValidateCustomerDetails(custDetailInqList.ToArray());
            }
            catch (Exception ee)
            {
                throw;
            }
        }

        public static void TestValidateNWSCCustomer()
        {
            try
            {

                esb.ValidcustNWSC customer = new esb.ValidcustNWSC();
                esb.webapi apiInst = new esb.webapi();
                var custDetailInqList = new List<esb.ValidcustReqz>();
                var custDetailResList = new List<esb.CustomerDetailz>();

                esb.ValidcustReqz custListItem = new esb.ValidcustReqz();

                esb.ValidcustNWSC cust = new esb.ValidcustNWSC();

                cust.strCustArea = "KAMPALA";
                cust.strCustomerRef = "21117391";
                cust.strsignature = "";
                cust.strUtilityCode = "002";
                cust.strVendorCode = "ebankitapp";
                cust.strVendorPassword = "D7@n0!@80o2";

                string stBankCertLocation = @"D:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
                string strBankCertPass = "DfcuBank1!";

                string strSignature = null;
                strSignature = cust.strUtilityCode.Trim() + cust.strCustomerRef.Trim() + cust.strCustArea.Trim() + cust.strVendorCode.Trim() + cust.strVendorPassword.Trim();

                X509Certificate2 x509Cert_bnk = new X509Certificate2();
                X509Certificate2Collection xer = new X509Certificate2Collection();
                X509Certificate2 xer2 = new X509Certificate2();
                xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
                xer2 = xer[0];

                RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
                byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

                byte[] signature = privateKey.SignData(buffer, "SHA1");

                //signature()
                cust.strsignature = Convert.ToBase64String(signature);

                custListItem.validcustNWSC = cust;
                custDetailInqList.Add(custListItem);

                esb.CustomerDetailz[] custResp = apiInst.ValidateCustomerDetails(custDetailInqList.ToArray());

                esb.ValidStudentIIU ghh = new esb.ValidStudentIIU();


            }
            catch (Exception ee)
            {
                throw;
            }
        }

        //nwsc
        public static void PostCustomerTransaction()
        {
            var amps = new List<esb.Validposttranz>();
            var r = new esb.Validposttranz();

            esb.webapi method = new esb.webapi();
            string strUtilityCode = "002";
            string strcustomerRef = "21236985";
            string strcustomerArea = "kampala";
            string strphone = "0704182361";
            string strdate = "21/11/2018";
            double amount = 1000;
            string mtd = "CASH";
            string reference = "1234554678";
            string strusr = "ebankitapp";
            string strpwd = "D7@n0!@80o2";


            string stBankCertLocation = @"D:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + strcustomerRef.Trim() + strcustomerArea.Trim() + strphone.Trim() + strdate.Trim() + amount + reference.Trim() + mtd.Trim() + strusr.Trim() + strpwd.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
            // esb.ValidateWaveCustomer wave = new esb.ValidateWaveCustomer
            esb.ValidpostNWSCTran nwsc = new esb.ValidpostNWSCTran
            {

                strUtilityCode = "002",
                strCustArea = "kampala",
                strCustomerRef = "21236985",
                strCustPhone = "0704182361",
                strPayMethod = "CASH",
                strTxnRef = "1234554678",
                strVendorCode = "ebankitapp",
                strVendorPassword = "D7@n0!@80o2",
                dblAmount = 1000,
                dtTxnDate = "21/11/2018",
                strsignature = strConvertedSignature,
            };
            r.validpostNWSCtran = nwsc;
            amps.Add(r);
            esb.TxnResultz[] dt = method.PostCustomerTransaction(amps.ToArray());
        }

        //IIU
        public static void NotifyIIU()
        {
            var amps = new List<esb.Validposttranz>();
            var r = new esb.Validposttranz();

            esb.webapi method = new esb.webapi();
            string strUtilityCode = "IIU";
            string prn = "2018113015235875544";
            string chequeNo = "";
            string amount = "50000";
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string phone = "0704182361";
            string yearOfStudy = "1";
            string sem = "2";
            string narration = "";
            string reference = "dfgdsdsfdgfg435";
            string vendorcode = "eutilitiesapp";
            string password = "D7@n0!@80o2";

            string stBankCertLocation = @"D:\pbucert\dfcubank.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + prn.Trim() + chequeNo.Trim() + amount + date.Trim() + phone.Trim() + yearOfStudy.Trim() + sem.Trim() + narration.Trim() + reference.Trim() + vendorcode.Trim() + password.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
            esb.NotifyStudentIIU iiu = new esb.NotifyStudentIIU
            {

                strUtilityCode = strUtilityCode,
                sem = sem,
                amount = amount,
                strprn= prn,
                strtranref = reference,
                chqno = chequeNo,
                naration = narration,
                phone = phone,
                yrofstudy = yearOfStudy,
                dtTxnDate = date,
                strVendorCode = vendorcode,
                strVendorPassword = password,                
                strsignature = strConvertedSignature,
            };
            r.notifyStudentIIU = iiu;
            amps.Add(r);
            esb.TxnResultz[] dt = method.PostCustomerTransaction(amps.ToArray());
        }

        public static void NotifySchoolPay()
        {
            var amps = new List<esb.Validposttranz>();
            var amps_inTran = new List<esb.ValidpostSchoolpayTran>();
            var amps_inFees = new List<esb.bulkPaymentWrapper>();
            var r = new esb.Validposttranz();

            esb.webapi method = new esb.webapi();

            int s_stramount = 100000;
            string s_strdepositor_name = "Amwine Patrick";
            string s_strdepositor_phone = "0779653858";
            string s_strmemo = "Sample Memo";
            string s_strprocessDate = DateTime.Now.ToString("dd/MM/yyyy");
            string s_strpwd = "D7@n0!@80o2";
            string s_strstudentpaymentcode = "1000026383";
            string s_strtran_id = "YHJEU73824NNMK";
            string s_strusr = "ebankitapp";
            string s_strUtilityCode = "016";

            string s_feeId = "1000";
            string s_feeMemo = "CHAGER";
            string s_tenderedAmount = "100000";


            string stBankCertLocation = @"D:\pbucert\dfcubank.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            
            strSignature = s_strUtilityCode.Trim() + s_strstudentpaymentcode.Trim() + s_stramount + s_strdepositor_phone + s_strdepositor_name.Trim() + s_strmemo.Trim() + s_strtran_id.Trim() + s_strusr.Trim() + s_strpwd.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);

            esb.SchoolpayTrandetails tranDet = new esb.SchoolpayTrandetails
            {
                stramount = s_stramount,
                strdepositor_name = s_strdepositor_name,
                strdepositor_phone = s_strdepositor_phone,
                strmemo = s_strmemo,
                strprocessDate = s_strprocessDate,
                strpwd = s_strpwd,
                strsignature = strConvertedSignature,
                strstudentpaymentcode = s_strstudentpaymentcode,
                strtran_id = s_strtran_id,
                strusr = s_strusr,
                strUtilityCode = s_strUtilityCode,
            };

            esb.bulkPaymentWrapper bfees = new esb.bulkPaymentWrapper
            {
                feeId = s_feeId,
                feeMemo = s_feeMemo,
                tenderedAmount = s_tenderedAmount,
            };

            amps_inFees.Add(bfees);

            esb.ValidpostSchoolpayTran iiu=new esb.ValidpostSchoolpayTran
            {
                schoolpaytrandetails=tranDet,
                feeassociations = amps_inFees.ToArray(),
                 
            };

            amps_inTran.Add(iiu);
            
            r.validpostschoolpaytran = amps_inTran.ToArray();
            amps.Add(r);
           
            esb.TxnResultz[] dt = method.PostCustomerTransaction(amps.ToArray());
        }

        //umeme
        public static void PostCustomerTransactionUmeme()
        {
            var amps = new List<esb.Validposttranz>();
            var r = new esb.Validposttranz();

            esb.webapi method = new esb.webapi();
            string strUtilityCode = "001";
            string strcustomerRef = "04240215527";
            string strphone = "0704182361";
            string strdate = "30/10/2018";
            double amount = 1000;
            string mtd = "CASH";
            string reference = "123456789";
            string strusr = "ebankitapp";
            string strpwd = "D7@n0!@80o2";


            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + strcustomerRef.Trim() + strphone.Trim() + strdate.Trim() + amount + reference.Trim() + mtd.Trim() + strusr.Trim() + strpwd.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
            // esb.ValidateWaveCustomer wave = new esb.ValidateWaveCustomer
            //esb.ValidpostNWSCTran nwsc = new esb.ValidpostNWSCTran
            esb.ValidpostUmemeUEDCLTran umeme = new esb.ValidpostUmemeUEDCLTran
            {
                strUtilityCode = "001",
                strCustomerRef = "04240215527",
                strCustPhone = "0704182361",
                strPayMethod = "CASH",
                strTxnRef = "123456789",
                strVendorCode = "ebankitapp",
                strVendorPassword = "D7@n0!@80o2",
                dblAmount = 1000,
                dtTxnDate = "30/10/2018",
                strsignature = strConvertedSignature,
            };
            r.validpostUmemeUEDCLtran = umeme;
            amps.Add(r);
            esb.TxnResultz[] dt = method.PostCustomerTransaction(amps.ToArray());
        }

        //hashing
        public static void Hashing()
        {
            string plain, hash;
            byte[] temp;

            plain = "testMessage";

            SHA1 sha = new SHA1CryptoServiceProvider();
            // This is one implementation of the abstract class SHA1.
            temp = sha.ComputeHash(Encoding.UTF8.GetBytes(plain));


            //storing hashed vale into byte data type
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                sb.Append(temp[i].ToString("x2"));
            }

            hash = sb.ToString();


            Console.WriteLine(hash);
            Console.ReadKey();
        }
        public static void TestValidateDSTV1()
        {
            try
            {

                esbgateway.ValidcustDSTV api = new DfcuTester.esbgateway.ValidcustDSTV();

                api.strUtilityCode = "003";
                api.strCustomerRef = "10459441720";
                api.strVendorCode = "eutilitiesapp";
                api.strVendorPassword = "D7@n0!@80o2";
                api.strsignature = api.strUtilityCode + api.strCustomerRef + api.strVendorCode + api.strVendorPassword;


            }
            catch (Exception ee)
            {
                throw;
            }
        }
        public static void GetAvailableProducts()
        {
            try
            {
                SelfCareService app = new SelfCareService();

                app.GetAvailableProducts("Uganda", "256261699", "true", "DSTV", "DFCUDStv", "English", "127.0.0.1", "DFCU");

            }
            catch (Exception ee)
            {
                throw;
            }
        }
        public static void Sign()
        {

            var samples = new List<esb.ValidcustReqz>();
            var p = new esb.ValidcustReqz();

            esb.webapi method = new esb.webapi();

            string strUtilityCode = "003";
            string strCustomerRef = "4623662097";//"10459441720";
            string strVendorCode = "eutilitiesapp";
            string strVendorPassword = "D7@n0!@80o2";

            string stBankCertLocation = @"E:\pbucert\dfcubank.pfx";
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + strCustomerRef.Trim() + strVendorCode.Trim() + strVendorPassword.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);

            esb.ValidcustDSTV dstv = new esb.ValidcustDSTV
            {
                strUtilityCode = "003",
                strCustomerRef = "4623662097",//"10459441720",
                strVendorCode = "eutilitiesapp",
                strVendorPassword = "D7@n0!@80o2",
                strProductType = "GOTV",
                strsignature = strConvertedSignature
            };

            p.validcustdstv = dstv;
            samples.Add(p);
            esb.CustomerDetailz[] ds = method.ValidateCustomerDetails(samples.ToArray());


        }

        public static void PostAgencyBankingDeposit2()
        {
            esbgateway.ValidpostAgencyDepositTran api = new esbgateway.ValidpostAgencyDepositTran();
            var samples = new List<esb.ValidpostAgencyBanktranz>();
            var p = new esb.ValidpostAgencyBanktranz();

            esb.webapi method = new esb.webapi();

            string strUtilityCode = "003";
            string strCustomerRef = "4623662097";//"10459441720";
            string strVendorCode = "eutilitiesapp";
            string strVendorPassword = "D7@n0!@80o2";

            string stBankCertLocation = @"E:\pbucert\dfcubank.pfx";
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            //(strUtilityCode + strCustomerRef + strCustArea + strVendorCode + strVendorPassword)
            strSignature = strUtilityCode.Trim() + strCustomerRef.Trim() + strVendorCode.Trim() + strVendorPassword.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);

            esb.ValidpostAgencyDepositTran txn = new esb.ValidpostAgencyDepositTran
            {
                strUtilityCode = "AGDEP",
                stracct_id = "01017004505938",
                strCustPhone = "0704182361",
                dtTxnDate = "04/10/2018",
                dblAmount = "10000",
                strnarration = "CASH DEPOSIT",
                strTxnRef = "20180816040419",
                strAgentID = "289264",
                strVendorCode = "ebankitapp",
                strVendorPassword = "D7@n0!@80o2",
                strsignature = strConvertedSignature
            };
            p.validpostagencydepositTran = txn;
            samples.Add(p);
            esb.TxnResultzAgencyBank[] ds = method.PostAgencyCustTransaction(samples.ToArray());

        }

        public static void ValidateWaveCustomer()
        {

            var amps = new List<esb.ValidAgencyReqz>();
            var r = new esb.ValidAgencyReqz();


            esb.webapi method = new esb.webapi();
            string strUtilityCode = "WAVE";
            string stracctid = "01013505079388";
            string strusr = "ebankitapp";
            string strpwd = "D7@n0!@80o2";


            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + stracctid.Trim() + strusr.Trim() + strpwd.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
            esb.ValidateWaveCustomer wave = new esb.ValidateWaveCustomer
            {
                strUtilityCode = "WAVE",
                stracctid = "01013505079388",
                strusr = "ebankitapp",
                strpwd = "D7@n0!@80o2",//D7@n0!@80o2
                strsignature = strConvertedSignature,
            };
            r.validateWaveCustomer = wave;
            amps.Add(r);
            esb.AgencyCustDetailz[] dt = method.ValidateAgencyCustDetails(amps.ToArray());

        }
        //w2b yo
        public static void ValidateW2BAccount()
        {

            var amps = new List<esb.ValidAgencyReqz>();
            var r = new esb.ValidAgencyReqz();


            esb.webapi method = new esb.webapi();
            string strUtilityCode = "W2B";
            string stracctid = "01013505079388";
            double amount = 1000;
            string strmsd = "256704182361";
            string strusr = "ebankitapp";
            string strpwd = "D7@n0!@80o2";


            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + stracctid.Trim() + amount + strmsd.Trim() + strusr.Trim() + strpwd.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
            esb.ValidateAccount w2b = new esb.ValidateAccount
            {
                strUtilityCode = "W2B",
                Account = "01013505079388",
                Amount = 1000,
                MSISDN = "256704182361",
                strusr = "ebankitapp",
                strpwd = "D7@n0!@80o2",//D7@n0!@80o2
                strsignature = strConvertedSignature,
            };
            r.validateAccount = w2b;
            amps.Add(r);
            esb.AgencyCustDetailz[] dt = method.ValidateAgencyCustDetails(amps.ToArray());

        }
        //nwsc
        public static void PostCustomerTransaction1()
        {
            var amps = new List<esb.Validposttranz>();
            var r = new esb.Validposttranz();

            esb.webapi method = new esb.webapi();
            string strUtilityCode = "002";
            string strcustomerRef = "21236985";
            string strcustomerArea = "kampala";
            string strphone = "0704182361";
            string strdate = "26/10/2018";
            double amount = 1000;
            string mtd = "CASH";
            string reference = "12345678";
            string strusr = "ebankitapp";
            string strpwd = "D7@n0!@80o2";


            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + strcustomerRef.Trim() + strcustomerArea.Trim() + strphone.Trim() + strdate.Trim() + amount + reference.Trim() + mtd.Trim() + strusr.Trim() + strpwd.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
            // esb.ValidateWaveCustomer wave = new esb.ValidateWaveCustomer
            esb.ValidpostNWSCTran nwsc = new esb.ValidpostNWSCTran
            {

                strUtilityCode = "002",
                strCustArea = "kampala",
                strCustomerRef = "21236985",
                strCustPhone = "0704182361",
                strPayMethod = "CASH",
                strTxnRef = "12345678",
                strVendorCode = "ebankitapp",
                strVendorPassword = "D7@n0!@80o2",
                dblAmount = 1000,
                dtTxnDate = "26/10/2018",
                strsignature = strConvertedSignature,
            };
            r.validpostNWSCtran = nwsc;
            amps.Add(r);
            esb.TxnResultz[] dt = method.PostCustomerTransaction(amps.ToArray());
        }

        //umeme
        public static void PostCustomerTransactionUmemeOther()
        {
            var amps = new List<esb.Validposttranz>();
            var r = new esb.Validposttranz();

            esb.webapi method = new esb.webapi();
            string strUtilityCode = "001";
            string strcustomerRef = "04240215527";
            string strphone = "0704182361";
            string strdate = "26/10/2018";
            double amount = 1000;
            string mtd = "CASH";
            string reference = "123456789";
            string strusr = "ebankitapp";
            string strpwd = "D7@n0!@80o2";


            string stBankCertLocation = @"E:\pbucert\prodx1.pfx";//E:\pbucert\testcerts
            string strBankCertPass = "DfcuBank1!";

            string strSignature = null;
            strSignature = strUtilityCode.Trim() + strcustomerRef.Trim() + strphone.Trim() + strdate.Trim() + amount + reference.Trim() + mtd.Trim() + strusr.Trim() + strpwd.Trim();

            X509Certificate2 x509Cert_bnk = new X509Certificate2();
            X509Certificate2Collection xer = new X509Certificate2Collection();
            X509Certificate2 xer2 = new X509Certificate2();
            xer.Import(stBankCertLocation, strBankCertPass, X509KeyStorageFlags.PersistKeySet);
            xer2 = xer[0];

            RSACryptoServiceProvider privateKey = xer2.PrivateKey as RSACryptoServiceProvider;
            byte[] buffer = new ASCIIEncoding().GetBytes(strSignature);

            byte[] signature = privateKey.SignData(buffer, "SHA1");

            //signature()
            string strConvertedSignature = null;
            strConvertedSignature = Convert.ToBase64String(signature);
            // esb.ValidateWaveCustomer wave = new esb.ValidateWaveCustomer
            //esb.ValidpostNWSCTran nwsc = new esb.ValidpostNWSCTran
            esb.ValidpostUmemeUEDCLTran umeme = new esb.ValidpostUmemeUEDCLTran
            {

                strUtilityCode = "001",
                strCustomerRef = "04240215527",
                strCustPhone = "0704182361",
                strPayMethod = "CASH",
                strTxnRef = "123456789",
                strVendorCode = "ebankitapp",
                strVendorPassword = "D7@n0!@80o2",
                dblAmount = 1000,
                dtTxnDate = "26/10/2018",
                strsignature = strConvertedSignature,
            };
            r.validpostUmemeUEDCLtran = umeme;
            amps.Add(r);
            esb.TxnResultz[] dt = method.PostCustomerTransaction(amps.ToArray());
        }
             
    }
}
