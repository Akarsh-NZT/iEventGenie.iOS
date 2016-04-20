using System;

namespace IEventGenie
{
	public enum ResponseStatus
	{
		OK,
		Fail,
		AuthorisationRequired
	}
	public enum AlertType
	{

	}

	public enum ControllerType
	{

	}

	public enum EditViType
	{

	}

	static public class AppConstant
	{
		#region URLS

		public const string BASE_URL = "https://dev.icheckingenie.com/DesktopModules/CheckinService/API/iCheckinEvents/";
		public const string GET_ALL_EVENT_ATTENDEE_DETAIL_BY_CONFIRMATION_CODE = "GetAllEventAttendeeDetailByConfirmationCode";
		public const string SUBMIT_PRECHECKIN = "SubmitPreCheckin";
		public const string CHECK_IN_WITH_CONFIRMATION_CODE = "CheckinWithConfirmation";
		public const string CHECK_OUT_WITH_CONFIRMATION_CODE = "CheckoutWithConfirmation";

		public const string CONFIRMATION_CODE_FOR_LOGIN = "confirmationCode";
		public const string LAST_NAME_FOR_LOGIN = "lastName";
		public const string DATA = "data";
		public const string SUCCESS = "success";
		public const string MESSAGE = "message";
		public const string PRECHECKIN_EVENT_ID = "eventId";
		public const string ATTENDEE_ID = "attendeeId";


		#endregion

		#region GETALLEVENTATTENDEEDETALBYCONFIRMATIONCODE

		public const string EVENTDETAILS = "eventDetails";
		public const string ACCT_ID = "Acct_Id";
		public const string CNFRM_CD_LGTH_NB = "Cnfrm_Cd_Lgth_Nb";
		public const string COMT_TXT = "Comt_Txt";
		public const string CRT_BY_USRID = "Crt_By_Usrid";
		public const string CRT_DTTM = "Crt_Dttm";
		public const string DEL_IND = "Del_Ind";
		public const string ENABLE_DB_SYNC_IN = "Enabl_Db_Sync_In";
		public const string ENABLE_IEVENTGENIE_DATASRC_IN = "Enabl_Ieventgenie_Data_Src_In";
		public const string ENABLE_CHECK_IN = "Enabl_Checkin";
		public const string ENABLE_PRECHECKIN = "Enabl_PreCheckin";
		public const string EV_ADDR_1_TXT = "Ev_Addr_1_Txt";
		public const string EV_ADDR_2_TXT  = "Ev_Addr_2_Txt";
		public const string EV_BARCD_TYPE_CD = "Ev_Barcd_Type_Cd";
		public const string EV_CD_TXT = "Ev_Cd_Txt";
		public const string EV_CHK_IN_END_DTTM = "Ev_Chk_In_End_Dttm";
		public const string EV_CHK_IN_STRT_DTTM = "Ev_Chk_In_Strt_Dttm";
		public const string EV_CITY_TXT = "Ev_City_Txt";
		public const string EV_CNTCT_ID = "Ev_Cntct_Id";
		public const string Ev_CONT_EMAIL = "Ev_Cont_Email";
		public const string EV_DESC = "Ev_Desc";
		public const string EV_EARLY_CHK_IN_END_DTTM = "Ev_Early_Chk_In_End_Dttm";
		public const string EV_EARLY_CHK_IN_START_DTTM = "Ev_Early_Chk_In_Strt_Dttm";
		public const string EV_END_DT = "Ev_End_Dt";
		public const string EV_ID = "Ev_Id";
		public const string EV_IMG_THUMB_URL = "Ev_Img_Thumb_Url";
		public const string EV_IMG_URL = "Ev_Img_Url";
		public const string EV_LOC_TXT = "Ev_Loc_Txt";
		public const string EV_NM = "Ev_Nm";
		public const string EV_ST_CD = "Ev_St_Cd";
		public const string EV_STRT_DT = "Ev_Strt_Dt";
		public const string EV_STS_CD = "Ev_Sts_Cd";
		public const string EV_TYPE_ID = "Ev_Type_Id";
		public const string EV_ZIP_CD = "Ev_Zip_Cd";
		public const string HOSTED_BY_TXT = "Hosted_By_Txt";
		public const string MOD_BY_USRID ="Mod_By_Usrid";
		public const string MOD_DTTM = "Mod_Dttm";
		public const string MODULE_ID = "ModuleId";
		public const string PARNT_EV_ID = "Parnt_Ev_Id";
		public const string PENDING_CHECKINS = "PendingCheckIns";
		public const string REGS_STRT_DT = "Regs_Strt_Dt";
		public const string SYNC_EV_ID = "Sync_Ev_Id";
		public const string TOTALATTENDEES = "TotalAttendees";
		public const string TOTAL_CHECKINS = "TotalCheckIns";
		public const string EV_TIME_ZONE = "Ev_Time_Zone";
		public const string EV_CONTACT_PHONE = "Ev_Contact_Phone";
		public const string EV_WEB_URL = "Ev_Web_Url";
		public const string SUBEVENTDETAILS = "subEventDetails";
		public const string MOBILE_CHECKINGSETTING = "MobileCheckingSettings";
		public const string ATTENDEE_CUSTOME_FIELD_SETTINGS = "AttendeeCustomFieldSettings";
		public const string HOUSING_CUSTOME_FIELD_SETTINGS = "HousingCustomFieldSettings";
		public const string VOLUNTEER_CUSTOME_FIELD_SETTINGS = "VolunteerCustomFieldSettings";
		public const string ATTENDEE_DETAILS = "attendeeDetails";
		public const string CATEGORY_TYPES = "categoryTypes";


		#endregion


		#region MOBILE_CHECKINGSETTING
		public const string CUSTM_FLD_1_SEL_IN= "Custm_Fld_1_Sel_In";
		public const string CUSTM_FLD_2_SEL_IN= "Custm_Fld_2_Sel_In";
		public const string CUSTM_FLD_3_SEL_IN= "Custm_Fld_3_Sel_In";
		public const string CUSTM_FLD_4_SEL_IN= "Custm_Fld_4_Sel_In";
		public const string CUSTM_FLD_5_SEL_IN= "Custm_Fld_5_Sel_In";
		public const string CUSTM_FLD_6_SEL_IN= "Custm_Fld_6_Sel_In";
		public const string CUSTM_FLD_7_SEL_IN= "Custm_Fld_7_Sel_In";
		public const string CUSTM_FLD_8_SEL_IN= "Custm_Fld_8_Sel_In";
		public const string CUSTM_FLD_9_SEL_IN= "Custm_Fld_9_Sel_In";
		public const string CUSTM_FLD_10_SEL_IN= "Custm_Fld_10_Sel_In";
		public const string CUSTM_FLD_11_SEL_IN= "Custm_Fld_11_Sel_In";
		public const string CUSTM_FLD_12_SEL_IN= "Custm_Fld_12_Sel_In";
		public const string CUSTM_FLD_13_SEL_IN= "Custm_Fld_13_Sel_In";
		public const string CUSTM_FLD_14_SEL_IN= "Custm_Fld_14_Sel_In";
		public const string CUSTM_FLD_15_SEL_IN= "Custm_Fld_15_Sel_In";
		public const string CUSTM_FLD_16_SEL_IN= "Custm_Fld_16_Sel_In";
		public const string CUSTM_FLD_17_SEL_IN= "Custm_Fld_17_Sel_In";
		public const string CUSTM_FLD_18_SEL_IN= "Custm_Fld_18_Sel_In";
		public const string CUSTM_FLD_19_SEL_IN= "Custm_Fld_19_Sel_In";
		public const string CUSTM_FLD_20_SEL_IN= "Custm_Fld_20_Sel_In";
		#endregion

		#region ATTENDEE_CUSTOME_FIELD_SETTINGS
		public const string FIELD_NAME = "fieldName";
		public const string IS_ON = "isOn";
		public const string CATEGORY = "Category";

		#endregion



		#region ATTENDEE_DETAILS

		public const string ID = "Id";
		public const string FIRST_NAME = "FirstName";
		public const string LAST_NAME = "LastName";
		public const string CONFIRMATION_CODE = "ConfirmationCode";
		public const string EMAIL = "Email";
		public const string GUESTS = "Guests";
		public const string PHONE_NUMBER = "PhoneNumber";
		public const string CITY = "City";
		public const string STATE = "State";
		public const string VALIDITY = "Validity";
		public const string NOTES = "Notes";
		public const string STATUS = "Status";
		public const string EVENT_ID = "EventId";
		public const string ATTENDEE_TYPE_ID = "AttendeeTypeId";
		public const string CUSTOME_FIELD_1 = "CustomField1";
		public const string CUSTOME_FIELD_2 = "CustomField2";
		public const string CUSTOME_FIELD_3 = "CustomField3";
		public const string CUSTOME_FIELD_4 = "CustomField4";
		public const string CUSTOME_FIELD_5 = "CustomField5";
		public const string CUSTOME_FIELD_6 = "CustomField6";
		public const string CUSTOME_FIELD_7 = "CustomField7";
		public const string CUSTOME_FIELD_8 = "CustomField8";
		public const string CUSTOME_FIELD_9 = "CustomField9";
		public const string CUSTOME_FIELD_10 = "CustomField10";
		public const string CUSTOME_FIELD_11 = "CustomField11";
		public const string CUSTOME_FIELD_12 = "CustomField12";
		public const string CUSTOME_FIELD_13 = "CustomField13";
		public const string CUSTOME_FIELD_14 = "CustomField14";
		public const string CUSTOME_FIELD_15 = "CustomField15";
		public const string CUSTOME_FIELD_16 = "CustomField16";
		public const string CUSTOME_FIELD_17 = "CustomField17";
		public const string CUSTOME_FIELD_18 = "CustomField18";
		public const string CUSTOME_FIELD_19 = "CustomField19";
		public const string CUSTOME_FIELD_20 = "CustomField20";

		#endregion

		#region CUSTOME_FIELD
		public const string LABEL= "Label";
		public const string VALUE= "Value";
		public const string IS_ENABLED= "IsEnabled";

		#endregion

		#region CATEGORY_TYPES

		public const string CHILDREN = "Children";
		public const string TEXT = "Text";
		#endregion

		#region BeaconsNotification

		public const string TITLE = "Title";
		public const string BEACON_TYPE_POP_UP = "51539607553";
		public const string BEACON_TYPE_CUSTOME = "51539607557";
		public const string BEACON_TYPE_WEB_VIEW = "51539607554";

		#endregion

		#region Check_In_Confirmation_Code

		public const string CONFIRMATION_NUMBER = "confirmationNumber";
	

		#endregion

	}
}

