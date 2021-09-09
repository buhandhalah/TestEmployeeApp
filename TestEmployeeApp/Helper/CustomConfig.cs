using SaberAmmsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SaberAmmsApp.Helper
{
    public class CustomConfig
    {

        private SABERAPPEntitiesLive1 db = new SABERAPPEntitiesLive1();
        public string FIREBASE_API_KEY = "";
        public string FIREBASE_SENDERID = "";
        public string SO_SEQTYPE  = "";
        public string MRF_SEQTYPE = "";
        public string TNO_SEQTYPE = "";
        public string ASSET_SEQTYPE = "";
        public string VASSET_SEQTYPE = "";
        public string ACTIVE_STAT = "";        
        public string JOB_SEQTYPE = "";
        public string DO_SEQTYPE  = "";
        public string ASTALLOC_SEQTYPE = "";

        //Production
        public string PROD_SEQTYPE = "";
        public string TEMP_SEQTYPE = "";

        public string Tic_upload_path = "";
        public string CusDoc_upload_path = "";
        public string VendorDoc_upload_path = "";
        public string VendorDoc_upload_path_signattach = "";
        public string VendorDoc_BalanceConfirmation = "";
        public string VendorDoc_BalanceConfirmationsignattach = "";
        public string AssetDoc_Handoversignattach = "";
        public string AssetDoc_Transfersignattach = "";
        public string AssetDoc_Returnsignattach = "";
        public string VAssetDoc_Handoversignattach = "";
        public string VAssetDoc_Transfersignattach = "";
        public string VAssetDoc_Returnsignattach = "";


        public string Temp_Signature_Image = "";
        public string StampPath = "";
        public string SignaturePath = "";

        public string Customer_BalanceConfirmation = "";
        public string Customer_BalanceConfirmationsignattach = "";

        public string Emp_Old_Docs_path = "";
        public string Emp_LbrCrd_Docs_path = "";
        public string Emp_DrivingLicense_Docs_path = "";
        public string Emp_ProfilePic_path = "";
        public string Emp_Experience_path = "";
        public string Emp_Training_path = "";
        public string Emp_DegreeQualification_path = "";
        public string Emp_BatchTemporary_path = "";
        public string Emp_Passport_path = "";
        public string EmpD_Passport_path = "";
        public string Emp_Visa_path = "";
        public string Emp_TemporaryWorkPermit_path = "";
        public string EmpD_Visa_path = "";
        public string Emp_EmiratesID_path = "";
        public string EmpD_EmiratesID_path = "";
        public string Emp_upload_path_signattach = "";
        public string Emp_D_Passport_path = "";
        public string CusDoc_upload_path_signattach = "";
        public string DOC_SEQTYPE = "";
        public string Doc_DO_SEQTYPE = "";
        public string Doc_upload_path = "";
        public string Doc_Currupted_path = "";
        public string Doc_upload_path_WorkAllocation = "";
        public string HRDoc_upload_path = "";
        public string HRDoc_upload_path_New = "";
        public string PCDoc_upload_path = "";
        public string PCDoc_Digital_path = "";
        public string IncrementLetterPath = "";
        public string BonusLetterPath = "";
        public string IncrementLetterGenerated_Path = "";

        public string Doc_Jobs_upload_path = "";
        public string EmailNotificationDoc_upload_path = ""; // for service support documents

        public string SupportDoc_upload_path = ""; // for service support documents
        public string SupportDoc_upload_path_hr2go = ""; // for service support documents
        public string EtisalatBills_upload_path = ""; // for service support documents


        public string Tic_Jobs_upload_path = ""; // for tic job attachments
        public string Tic_Jobs_upload_path1 = ""; // for tic chatbox attachments
        public string Email_template_path = "";
        public string ENV_NO       = "";

        public string ICVCertification_path = ""; //icv certification

        public string Emp_Service_attach_path  = "";
        public string Emp_PaySlip_attach_path  = "";
        public string Att_Face_path            = "";
        public string Att_Approval_Attachments = "";

        public string HRPFXDoc_upload_path = "";
        public string FaceAuth_upload_path = "";


        public string Asset_Pic_path = "";
        public string Asset_type_icon_path = "";
        public string VAsset_sold_path = "";
        public string VAsset_Pic_path = "";
        public string Asset_supportfile_path = "";
        public string VAsset_supportfile_path = "";
        public string VAsset_Expense_path = "";
        //CRM
        public string crm_account_logos = "";
        public string crm_contact_vc = "";
        public string crm_qtn_upload_path = "";
        public string crm_task_upload_path = "";
        public string crm_Collectiontask_upload_path = "";
        public string crm_activity_upload_path = "";
        public string crm_Collectionactivity_upload_path = "";
        public string crm_Cust_Status = "";
        public string crm_Cust_Ret_Status = "";
        public string crm_Vend_Status = "";
        public static List<ItemNo> pInvoicesLst = new List<ItemNo>(); //Invoice payable
        public static List<ItemNo> VendAdvpInvoicesLst = new List<ItemNo>(); //Vend Adv pay Invoice payable
        public static List<ItemNo> RetInvoicesLst = new List<ItemNo>(); //Invoice Ret
        public static List<ItemNo> ApRETPayInvoiceLst = new List<ItemNo>(); //Invoice Vend Ret
        public static List<CRM_AAR_ReportTbl> CRM_ageingAAR_ReportTblLst { get; set; } // FOR CUST ageing SUMMARY RECEIVABLES
        public static List<ItemNo> CRM_ageingCRET_ReportTblLst { get; set; } // FOR CUST ageing SUMMARY RETENTION
        public static List<ItemNo> CRM_ageingCADV_ReportTblLst { get; set; } // FOR CUST ageing SUMMARY RETENTION

        public static List<CRM_AAP_ReportTbl> CRM_ageingAAP_ReportTblLst { get; set; } // FOR VEND ageing SUMMARY RECEIVABLES
        public static List<ItemNo> CRM_ageingVRET_ReportTblLst { get; set; } // FOR VEND ageing SUMMARY RETENTION
        public static List<ItemNo> CRM_ageingVADV_ReportTblLst { get; set; } // FOR VEND ageing SUMMARY RETENTION
        //Payportal
        public string pay_req_path     = "";
        public string pay_invoice_path = "";
        public string pay_req_item_path = "";
        public string pay_req_customer_attach_path = "";
        public string pay_req_txn_attach_path = "";
        //PACE
        public string Pace_CatPic_Upload_path = "";
        public string Pace_AssemblyPic_Upload_path = "";

        public string Pace_OriginalContract_Upload_path = "";
        public string Pace_CostEstimation_Upload_path = "";
        public string Pace_BillofQuantities_Upload_path = "";
        public string Pace_ProjectSchedule_Upload_path = "";

        /**Email Configs**/
        public string SMTP_HOST = "";
        public bool ENABLE_SSL = true;
        public int Port = 0;
        public string FROM_UNAME = "";
        public string FROM_PASS = "";
        public string FROM_UNAME_P = "";
        public string FROM_PASS_P = "";
        //Production
        public string Production_path = "";

    
        public const int SimPending = 1;
        public const int SimAllocated = 2;
        public const int SimUnAllocated = 3;

        /* for vehicle expense approval -- ashik     */
        public const int Pending = 1;
        public const int Approved = 2;
        public const int Rejected = 3;
        /* ** */

        public const int create = 1;
        public const int update = 2;
        public const int edit= 3;

        public const int RequestNotViewed = 1;
        public const int RequestViewed = 2;
        public const int RequestApproved = 3;
        public const int RequestDisregard = 4;

        public const int RegistrationDocument = 1;
        public const int InsuranceDocument = 2;

        /**
         * Title : Dynamic form creation
         * Author: Aldon
         * Date : 13-july-2020
         ***/
        public string FORMHeader_SEQTYPE = "";

        public CustomConfig()
        {
            try
            {
               List<View_App_Configs> model = db.View_App_Configs.ToList();
                ACTIVE_STAT       = "Active";
                FIREBASE_API_KEY  = "AAAAXNqEkko:APA91bHFrnfAPdjCYiTUzCMtHxHuwvQFuMgGlu01pX0frPFy5Mnan1rm0kkH_f2LwiGkChm8UVwCdoQYcrb62KqRLyCoQcVfEvvmqNnX1ka_cCLYtPVcy2zpbP2IZ_Vm6LjT4d6Ekru_";
                FIREBASE_SENDERID = "398803112522";
                if (model!=null)
                {
                    foreach(var item in model)
                    {
                        if (item.ConfigName.Equals("SoSeqType"))
                        {
                            SO_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("MrfSeqType"))
                        {
                            MRF_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("TnoSeqType"))
                        {
                            TNO_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("JobSeqType"))
                        {
                            JOB_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("DOSeqType"))
                        {
                            DO_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("DOCSeqType"))
                        {
                            DOC_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("Doc_DO_SEQTYPE"))
                        {
                            Doc_DO_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("ENVSeqType"))
                        {
                            ENV_NO = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("AssetSeqType"))
                        {
                            ASSET_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("VAssetSeqType"))
                        {
                            VASSET_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("FormHeaderSeqType"))
                        {
                            FORMHeader_SEQTYPE = item.FirstPart;
                        }
                        // Production
                        if (item.ConfigName.Equals("ProdSeqType"))
                        {
                            PROD_SEQTYPE = item.FirstPart;
                        }

                        if (item.ConfigName.Equals("TempSeqType"))
                        {
                            TEMP_SEQTYPE = item.FirstPart;
                        }
                        if (item.ConfigName.Equals("AsstTypeAllocSeqType"))
                        {
                            ASTALLOC_SEQTYPE = item.FirstPart;
                        }
                    }
                }

                this.emailConfig();
                this.emailConfig_poboxapp();

                //

                FaceAuth_upload_path = "~/Uploads1/FaceAuth_Data/";

                Doc_upload_path = "~/Uploads1/docs/";
                Doc_Currupted_path = "~/Uploads1/CurreptedDocs/";
                Doc_upload_path_WorkAllocation = "~/Uploads1/WorkAllocation/";
                HRDoc_upload_path = "~/Uploads1/HRdocs/";
                HRDoc_upload_path_New = "~/Uploads1/HRdocs_New/";
                IncrementLetterPath = "~/Uploads1/IncrementLetterUploadFile/";
                BonusLetterPath = "~/Uploads1/BonusLetterUploadFile/";
                IncrementLetterGenerated_Path = "~/Uploads1/IncrementLetterGeneratedFiles/";
                HRPFXDoc_upload_path = "~/Uploads1/PFXFiles/";

                Doc_Jobs_upload_path = "~/Uploads1/docsJobs/";
                Tic_Jobs_upload_path = "~/Uploads1/ticsJobs/"; // for tic jobs attachments.
                Tic_Jobs_upload_path1 = "~/Uploads1/ticsChatboxAttachments/"; // for tic chatbox attachments.
                SupportDoc_upload_path = "~/Uploads1/ServiceAndDocs/";
                SupportDoc_upload_path_hr2go = "~/Uploads1/HRdocs/";
                EtisalatBills_upload_path = "~/Uploads1/EtisalatExcelDocs/";


                EmailNotificationDoc_upload_path = "~/Uploads1/EmailNotification/";

                Email_template_path = "~/Email_Templates/";
                //Tic_upload_path = "~/Img/UploadedFiles/TicketsRelated";
                Tic_upload_path = "~/Uploads1/TicketsRelated/";                
                CusDoc_upload_path = "~/Uploads1/CusDetailsRelated/";
                VendorDoc_upload_path = "~/Uploads1/VendorDetailsRelated/";
                VendorDoc_upload_path_signattach = "~/Uploads1/VendorDetailsRelated/signedfiles/";
                VendorDoc_BalanceConfirmationsignattach = "~/Uploads1/VendorBC/signedfiles/"; 
                VendorDoc_BalanceConfirmation = "~/Uploads1/VendorBC/";
                AssetDoc_Handoversignattach = "~/Uploads1/Assets/Handoversignedfiles/";
                AssetDoc_Returnsignattach = "~/Uploads1/Assets/Returnsignedfiles/";
                AssetDoc_Transfersignattach = "~/Uploads1/Assets/Transfersignedfiles/";

                VAssetDoc_Handoversignattach = "~/Uploads1/VAssets/Handoversignedfiles/";
                VAssetDoc_Returnsignattach = "~/Uploads1/VAssets/Returnsignedfiles/";
                VAssetDoc_Transfersignattach = "~/Uploads1/VAssets/Transfersignedfiles/";


                Customer_BalanceConfirmationsignattach = "~/Uploads1/CustomerBC/signedfiles/";
                Customer_BalanceConfirmation = "~/Uploads1/CustomerBC/";

                Emp_Training_path = "~/Uploads1/EmployeeService/CourceAndTraining/";
                Emp_DegreeQualification_path = "~/Uploads1/EmployeeService/DegreeAndQualifications/";
                Emp_BatchTemporary_path = "~/Uploads1/EmployeeService/TemporaryBatchJobs/";
                Emp_Old_Docs_path = "~/Uploads1/EmployeeService/EmpOldDocsFiles/";
                Emp_LbrCrd_Docs_path = "~/Uploads1/EmployeeService/EmpLaborCardFiles/";
                Emp_DrivingLicense_Docs_path = "~/Uploads1/EmployeeService/EmpDrivingLicenseFiles/";
                Emp_Experience_path = "~/Uploads1/EmployeeService/WorkExperience/";
                Emp_Passport_path = "~/Uploads1/EmployeeService/EmpPassportFiles/";
                EmpD_Passport_path = "~/Uploads1/EmployeeService/EmpDependentPassportFiles/";
                Emp_Visa_path = "~/Uploads1/EmployeeService/EmpVisaFiles/";
                Emp_TemporaryWorkPermit_path = "~/Uploads1/EmployeeService/EmpTemporaryWorkPermitFiles/";
                EmpD_Visa_path = "~/Uploads1/EmployeeService/EmpDependentVisaFiles/";
                Emp_EmiratesID_path = "~/Uploads1/EmployeeService/EmpEmiratesIDFiles/";
                EmpD_EmiratesID_path = "~/Uploads1/EmployeeService/EmpDependentEmiratesIDFiles/";
                Emp_upload_path_signattach = "~/Uploads1/EmployeeService/Finalsignedfiles/";
                Emp_D_Passport_path = "~/Uploads1/EmployeeService/EmpDependentPassport/";
                CusDoc_upload_path_signattach = "~/Uploads1/CusDetailsRelated/signedfiles/";
                Emp_ProfilePic_path = "~/Uploads1/EmployeeService/EmpProfilePiccture/";
                Emp_Service_attach_path = "~/Uploads1/EmployeeService/EmpServiceAttachments/";
                Emp_PaySlip_attach_path = "~/Uploads1/Payroll/PaySlip/";

                ICVCertification_path = "~/Uploads1/VendorDetailsRelated/";

                Att_Face_path = "~/Uploads1/Attendance/Face/";
                Att_Approval_Attachments = "~/Uploads1/Attendance/ApprovalAttachments/";

                Asset_Pic_path = "~/Uploads1/Assets/pic/";
                Asset_type_icon_path = "~/Uploads1/AssetType/icon/";
                VAsset_sold_path = "~/Uploads1/VehicleSold/approvals/";
                VAsset_Pic_path = "~/Uploads1/VAssets/pic/";
                Asset_supportfile_path = "~/Uploads1/Assets/supportfiles/";
                VAsset_supportfile_path = "~/Uploads1/VAssets/supportfiles/";
                VAsset_Expense_path = "~/Uploads1/VAssets/Expenses/";
                crm_account_logos = "~/Uploads1/CRM/Accounts/Logos/";
                crm_contact_vc    = "~/Uploads1/CRM/Contacts/VC/";
                crm_qtn_upload_path = "~/Uploads1/CRM/Quotations/";
                crm_activity_upload_path = "~/Uploads1/CRM/Activity/";
                crm_task_upload_path = "~/Uploads1/CRM/Task/";
                crm_activity_upload_path = "~/Uploads1/CRM/Activity/";
                crm_Collectionactivity_upload_path = "~/Uploads1/CRM/CollectionActivity/"; //Ameer
                crm_Collectiontask_upload_path = "~/Uploads1/CRM/CollectionTask/"; //Ameer
                crm_Cust_Status = "~/Uploads1/CRM/CustStatus/"; //Ameer
                crm_Cust_Ret_Status = "~/Uploads1/CRM/CustRetStatus/"; //Ameer
                crm_Vend_Status = "~/Uploads1/CRM/VendStatus/"; //Ameer
                pay_req_path      = "~/Uploads1/Pay/Request/SupportDocs/";
                pay_invoice_path  = "~/Uploads1/Pay/Request/Invoice/";
                pay_req_item_path = "~/Uploads1/Pay/Request/Items/";
                pay_req_customer_attach_path = "~/Uploads1/Pay/Request/CustomerAttachs/";
                pay_req_txn_attach_path = "~/Uploads1/Pay/Request/Txn/";

                Production_path = "~/Uploads1/Production/Jobs/";

                FaceAuth_upload_path = "~/Uploads1/FaceAuth_Data/";

                // PACE
                Pace_CatPic_Upload_path = "~/Uploads1/PACE/CategoryRelated/";
                Pace_AssemblyPic_Upload_path = "~/Uploads1/PACE/AssemblyRelated/";

                Pace_OriginalContract_Upload_path = "~/Uploads1/PACE/Estimation/OriginalContract/";
                Pace_CostEstimation_Upload_path = "~/Uploads1/PACE/Estimation/CostEstimation/";
                Pace_BillofQuantities_Upload_path = "~/Uploads1/PACE/Estimation/BillofQuantities/";
                Pace_ProjectSchedule_Upload_path = "~/Uploads1/PACE/Estimation/ProjectSchedule/";

                Temp_Signature_Image = "~/Uploads1/DummySignImages/";
                StampPath = "~/Img/CompanyStamp/";
                SignaturePath = "~/Img/SignatureImg/";

            }
            catch(Exception e) { }
        }

        private void emailConfig()
        {
         SMTP_HOST = "smtp.office365.com";
         ENABLE_SSL = true;
         Port       = 587;
         FROM_UNAME = "webadmin@sbrgroup.ae";
         FROM_PASS  = "sbr_1234";
       }
        private void emailConfig_poboxapp()
        {
            SMTP_HOST = "smtp.office365.com";
            ENABLE_SSL = true;
            Port = 587;
            FROM_UNAME_P = "upm@sbrgroup.ae";
            FROM_PASS_P = "sbr_12345";
        }
    }
}