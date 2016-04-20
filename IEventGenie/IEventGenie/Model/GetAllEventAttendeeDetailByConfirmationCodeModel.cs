using System;
using System.Collections.Generic;

namespace IEventGenie
{
	public class GetAllEventAttendeeDetailByConfirmationCodeModel : BaseModel
	{
		public string Acct_Id{ get; set;}
		public string Cnfrm_Cd_Lgth_Nb{ get; set;}
		public string Comt_Txt{ get; set;}
		public string Crt_By_Usrid{ get; set;}
		public string Crt_Dttm{ get; set;}
		public string Del_Ind{ get; set;}
		public string Enabl_Db_Sync_In{ get; set;}
		public string Enabl_Ieventgenie_Data_Src_In{ get; set;}
		public string Enabl_Checkin{ get; set;}
		public string Enabl_PreCheckin{ get; set;}
		public string Ev_Addr_1_Txt{ get; set;}
		public string Ev_Addr_2_Txt{ get; set;}
		public string Ev_Barcd_Type_Cd{ get; set;}
		public string Ev_Cd_Txt{ get; set;}
		public string Ev_Chk_In_End_Dttm{ get; set;}
		public string Ev_Chk_In_Strt_Dttm{ get; set;}
		public string Ev_City_Txt{ get; set;}
		public string Ev_Cntct_Id{ get; set;}
		public string Ev_Cont_Email{ get; set;}
		public string Ev_Desc{ get; set;}
		public string Ev_Early_Chk_In_End_Dttm{ get; set;}
		public string Ev_Early_Chk_In_Strt_Dttm{ get; set;}
		public string Ev_End_Dt{ get; set;}
		public string Ev_Id{ get; set;}
		public string Ev_Img_Thumb_Url{ get; set;}
		public string Ev_Img_Url{ get; set;}
		public string Ev_Loc_Txt{ get; set;}
		public string Ev_Nm{ get; set;}
		public string Ev_St_Cd{ get; set;}
		public string Ev_Strt_Dt{ get; set;}
		public string Ev_Sts_Cd{ get; set;}
		public string Ev_Type_Id{ get; set;}
		public string Ev_Zip_Cd{ get; set;}
		public string Hosted_By_Txt{ get; set;}
		public string Mod_By_Usrid{ get; set;}
		public string Mod_Dttm{ get; set;}
		public string ModuleId{ get; set;}
		public string Parnt_Ev_Id{ get; set;}
		public string PendingCheckIns{ get; set;}
		public string Regs_Strt_Dt{ get; set;}
		public string Sync_Ev_Id{ get; set;}
		public string TotalAttendees{ get; set;}
		public string TotalCheckIns{ get; set;}
		public string Ev_Time_Zone{ get; set;}
		public string Ev_Contact_Phone{ get; set;}
		public string Ev_Web_Url{ get; set;}
		public string subEventDetails{ get; set;} /*Need to Rework*/
		public MobileCheckingSettingsModel MobileCheckingSettings{ get; set;}
		public List<AttendeeCustomFieldSettingsModel> AttendeeCustomFieldSettings{ get; set;}
		public List<HousingCustomFieldSettingsModel> HousingCustomFieldSettings{ get; set;}
		public List<VolunteerCustomFieldSettingsModel> VolunteerCustomFieldSettings{ get; set;}
		public AttendeeDetailsModel attendeeDetails{ get; set;}
		public List<CategoryTypesModel> categoryTypes{ get; set;}



	}
}

