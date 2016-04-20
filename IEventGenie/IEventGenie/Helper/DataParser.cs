using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace IEventGenie
{
	public static class DataParser
	{
		#region IsKeyExist

		private static bool IsKeyExist(string key , Dictionary<string,object> data)
		{
			if (key == null || key.Trim ().Length == 0 || data == null)
				return false;

			if (data.ContainsKey (key))
				return true;

			return false;
		}

		#endregion

		#region GetData

		private static string GetData(string key , Dictionary<string,object> data)
		{
			if (key == null || key.Trim ().Length == 0 || data == null)
				return null;

			if (data [key] == null)
				return "";

			string dataString = data [key].ToString();

			if (dataString == null || dataString.Trim ().Length == 0)
			return "";		else

				return dataString.Trim ();
		}
			

		#endregion

		#region  GETALLEVENTATTENDEEDEATILBYCONFIRMATIONCODEMODEL
		public static GetAllEventAttendeeDetailByConfirmationCodeModel ParseGetAllEventAttendeeDetailByConfirmationCode(string key,Dictionary<string,object> data)
		{

			if (Validator.IsDataNull (data)) 
			{
				System.Diagnostics.Debug.WriteLine("In GetAllEventAttendeeDetailByConfirmationCode() data dictionary is null");
				return null;
			}
			GetAllEventAttendeeDetailByConfirmationCodeModel model = new GetAllEventAttendeeDetailByConfirmationCodeModel ();


			JArray jar =  data [AppConstant.EVENTDETAILS] as JArray;

			for (int i = 0; i < jar.Count; i++) {

				JObject obj = jar [i] as JObject;

				Dictionary<string,object> dict = obj.ToObject<Dictionary<string,object>> ();

				if (IsKeyExist (AppConstant.ACCT_ID, dict))
					model.Acct_Id = GetData (AppConstant.ACCT_ID, dict);

				if (IsKeyExist (AppConstant.CNFRM_CD_LGTH_NB, dict))
					model.Cnfrm_Cd_Lgth_Nb = GetData (AppConstant.CNFRM_CD_LGTH_NB, dict);

				if (IsKeyExist (AppConstant.COMT_TXT, dict))
					model.Comt_Txt = GetData (AppConstant.COMT_TXT, dict);

				if (IsKeyExist (AppConstant.CRT_BY_USRID, dict))
					model.Crt_By_Usrid = GetData (AppConstant.CRT_BY_USRID, dict);

				if (IsKeyExist (AppConstant.CRT_DTTM, dict))
					model.Crt_Dttm = GetData (AppConstant.CRT_DTTM, dict);

				if (IsKeyExist (AppConstant.DEL_IND, dict))
					model.Del_Ind = GetData (AppConstant.DEL_IND, dict);

				if (IsKeyExist (AppConstant.ENABLE_DB_SYNC_IN, dict))
					model.Enabl_Db_Sync_In = GetData (AppConstant.ENABLE_DB_SYNC_IN, dict);

				if (IsKeyExist (AppConstant.ENABLE_IEVENTGENIE_DATASRC_IN, dict))
					model.Enabl_Ieventgenie_Data_Src_In = GetData (AppConstant.ENABLE_IEVENTGENIE_DATASRC_IN, dict);

				if (IsKeyExist (AppConstant.ENABLE_CHECK_IN, dict))
					model.Enabl_Checkin = GetData (AppConstant.ENABLE_CHECK_IN, dict);

				if (IsKeyExist (AppConstant.ENABLE_PRECHECKIN, dict))
					model.Enabl_PreCheckin = GetData (AppConstant.ENABLE_PRECHECKIN, dict);

				if (IsKeyExist (AppConstant.EV_ADDR_1_TXT, dict))
					model.Ev_Addr_1_Txt = GetData (AppConstant.EV_ADDR_1_TXT, dict);


				if (IsKeyExist (AppConstant.EV_ADDR_2_TXT, dict))
					model.Ev_Addr_2_Txt = GetData (AppConstant.EV_ADDR_2_TXT, dict);

				if (IsKeyExist (AppConstant.EV_BARCD_TYPE_CD, dict))
					model.Ev_Barcd_Type_Cd = GetData (AppConstant.EV_BARCD_TYPE_CD, dict);


				if (IsKeyExist (AppConstant.EV_CD_TXT, dict))
					model.Ev_Cd_Txt = GetData (AppConstant.EV_CD_TXT, dict);

				if (IsKeyExist (AppConstant.EV_CHK_IN_END_DTTM, dict))
					model.Ev_Chk_In_End_Dttm = GetData (AppConstant.EV_CHK_IN_END_DTTM, dict);

				if (IsKeyExist (AppConstant.EV_CHK_IN_STRT_DTTM, dict))
					model.Ev_Chk_In_Strt_Dttm = GetData (AppConstant.EV_CHK_IN_STRT_DTTM, dict);

				if (IsKeyExist (AppConstant.EV_CITY_TXT, dict))
					model.Ev_City_Txt = GetData (AppConstant.EV_CITY_TXT, dict);

				if (IsKeyExist (AppConstant.EV_CNTCT_ID, dict))
					model.Ev_Cntct_Id = GetData (AppConstant.EV_CNTCT_ID, dict);

				if (IsKeyExist (AppConstant.Ev_CONT_EMAIL, dict))
					model.Ev_Cont_Email = GetData (AppConstant.Ev_CONT_EMAIL, dict);

				if (IsKeyExist (AppConstant.EV_DESC, dict))
					model.Ev_Desc = GetData (AppConstant.EV_DESC, dict);

				if (IsKeyExist (AppConstant.EV_EARLY_CHK_IN_END_DTTM, dict))
					model.Ev_Early_Chk_In_End_Dttm = GetData (AppConstant.EV_EARLY_CHK_IN_END_DTTM, dict);

				if (IsKeyExist (AppConstant.EV_EARLY_CHK_IN_START_DTTM, dict))
					model.Ev_Early_Chk_In_Strt_Dttm = GetData (AppConstant.EV_EARLY_CHK_IN_START_DTTM, dict);

				if (IsKeyExist (AppConstant.EV_END_DT, dict))
					model.Ev_End_Dt = GetData (AppConstant.EV_END_DT, dict);

				if (IsKeyExist (AppConstant.EV_ID, dict))
					model.Ev_Id = GetData (AppConstant.EV_ID, dict);

				if (IsKeyExist (AppConstant.EV_IMG_THUMB_URL, dict))
					model.Ev_Img_Thumb_Url = GetData (AppConstant.EV_IMG_THUMB_URL, dict);

				if (IsKeyExist (AppConstant.EV_IMG_URL, dict))
					model.Ev_Img_Url = GetData (AppConstant.EV_IMG_URL, dict);

				if (IsKeyExist (AppConstant.EV_LOC_TXT, dict))
					model.Ev_Loc_Txt = GetData (AppConstant.EV_LOC_TXT, dict);

				if (IsKeyExist (AppConstant.EV_NM, dict))
					model.Ev_Nm = GetData (AppConstant.EV_NM, dict);

				if (IsKeyExist (AppConstant.EV_ST_CD, dict))
					model.Ev_St_Cd = GetData (AppConstant.EV_ST_CD, dict);

				if (IsKeyExist (AppConstant.EV_STRT_DT, dict))
					model.Ev_Strt_Dt = GetData (AppConstant.EV_STRT_DT, dict);

				if (IsKeyExist (AppConstant.EV_STS_CD, dict))
					model.Ev_Sts_Cd = GetData (AppConstant.EV_STS_CD, dict);


				if (IsKeyExist (AppConstant.EV_TYPE_ID, dict))
					model.Ev_Type_Id = GetData (AppConstant.EV_TYPE_ID, dict);

				if (IsKeyExist (AppConstant.EV_ZIP_CD, dict))
					model.Ev_Zip_Cd = GetData (AppConstant.EV_ZIP_CD, dict);

				if (IsKeyExist (AppConstant.HOSTED_BY_TXT, dict))
					model.Hosted_By_Txt = GetData (AppConstant.HOSTED_BY_TXT, dict);

				if (IsKeyExist (AppConstant.MOD_BY_USRID, dict))
					model.Mod_By_Usrid = GetData (AppConstant.MOD_BY_USRID, dict);

				if (IsKeyExist (AppConstant.MOD_DTTM, dict))
					model.Mod_Dttm = GetData (AppConstant.MOD_DTTM, dict);

				if (IsKeyExist (AppConstant.MODULE_ID, dict))
					model.ModuleId = GetData (AppConstant.MODULE_ID, dict);

				if (IsKeyExist (AppConstant.PARNT_EV_ID, dict))
					model.Parnt_Ev_Id = GetData (AppConstant.PARNT_EV_ID, dict);

				if (IsKeyExist (AppConstant.PENDING_CHECKINS, dict))
					model.PendingCheckIns = GetData (AppConstant.PENDING_CHECKINS, dict);

				if (IsKeyExist (AppConstant.REGS_STRT_DT, dict))
					model.Regs_Strt_Dt = GetData (AppConstant.REGS_STRT_DT, dict);


				if (IsKeyExist (AppConstant.SYNC_EV_ID, dict))
					model.Sync_Ev_Id = GetData (AppConstant.SYNC_EV_ID, dict);

				if (IsKeyExist (AppConstant.TOTALATTENDEES, dict))
					model.TotalAttendees = GetData (AppConstant.TOTALATTENDEES, dict);

				if (IsKeyExist (AppConstant.TOTAL_CHECKINS, dict))
					model.TotalCheckIns = GetData (AppConstant.TOTAL_CHECKINS, dict);

				if (IsKeyExist (AppConstant.EV_TIME_ZONE, dict))
					model.Ev_Time_Zone = GetData (AppConstant.EV_TIME_ZONE, dict);

				if (IsKeyExist (AppConstant.EV_CONTACT_PHONE, dict))
					model.Ev_Contact_Phone = GetData (AppConstant.EV_CONTACT_PHONE, dict);

				if (IsKeyExist (AppConstant.EV_WEB_URL, dict))
					model.Ev_Web_Url = GetData (AppConstant.EV_WEB_URL, dict);

				if (IsKeyExist (AppConstant.SUBEVENTDETAILS, dict))
					model.subEventDetails = GetData (AppConstant.SUBEVENTDETAILS, dict);

				if (IsKeyExist (AppConstant.MOBILE_CHECKINGSETTING, dict)) {
					string listArray = ""+GetData (AppConstant.MOBILE_CHECKINGSETTING, dict);

					MobileCheckingSettingsModel inmodel = new MobileCheckingSettingsModel ();

					JObject mobileObj = dict [AppConstant.MOBILE_CHECKINGSETTING] as JObject;

					for (int j = 0; j < mobileObj.Count; j++) {

						Dictionary<string,object> indict = mobileObj.ToObject<Dictionary<string,object>> ();

						if (IsKeyExist (AppConstant.CUSTM_FLD_1_SEL_IN, indict))
							inmodel.Custm_Fld_1_Sel_In = GetData (AppConstant.CUSTM_FLD_1_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_2_SEL_IN, indict))
							inmodel.Custm_Fld_2_Sel_In = GetData (AppConstant.CUSTM_FLD_2_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_3_SEL_IN, indict))
							inmodel.Custm_Fld_3_Sel_In = GetData (AppConstant.CUSTM_FLD_3_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_4_SEL_IN, indict))
							inmodel.Custm_Fld_4_Sel_In = GetData (AppConstant.CUSTM_FLD_4_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_5_SEL_IN, indict))
							inmodel.Custm_Fld_5_Sel_In = GetData (AppConstant.CUSTM_FLD_5_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_6_SEL_IN, indict))
							inmodel.Custm_Fld_6_Sel_In = GetData (AppConstant.CUSTM_FLD_6_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_7_SEL_IN, indict))
							inmodel.Custm_Fld_7_Sel_In = GetData (AppConstant.CUSTM_FLD_7_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_8_SEL_IN, indict))
							inmodel.Custm_Fld_8_Sel_In = GetData (AppConstant.CUSTM_FLD_8_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_9_SEL_IN, indict))
							inmodel.Custm_Fld_9_Sel_In = GetData (AppConstant.CUSTM_FLD_9_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_10_SEL_IN, indict))
							inmodel.Custm_Fld_10_Sel_In = GetData (AppConstant.CUSTM_FLD_10_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_11_SEL_IN, indict))
							inmodel.Custm_Fld_11_Sel_In = GetData (AppConstant.CUSTM_FLD_11_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_12_SEL_IN, indict))
							inmodel.Custm_Fld_12_Sel_In = GetData (AppConstant.CUSTM_FLD_12_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_13_SEL_IN, indict))
							inmodel.Custm_Fld_13_Sel_In = GetData (AppConstant.CUSTM_FLD_13_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_14_SEL_IN, indict))
							inmodel.Custm_Fld_14_Sel_In = GetData (AppConstant.CUSTM_FLD_14_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_15_SEL_IN, indict))
							inmodel.Custm_Fld_15_Sel_In = GetData (AppConstant.CUSTM_FLD_15_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_16_SEL_IN, indict))
							inmodel.Custm_Fld_16_Sel_In = GetData (AppConstant.CUSTM_FLD_16_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_17_SEL_IN, indict))
							inmodel.Custm_Fld_17_Sel_In = GetData (AppConstant.CUSTM_FLD_17_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_18_SEL_IN, indict))
							inmodel.Custm_Fld_18_Sel_In = GetData (AppConstant.CUSTM_FLD_18_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_19_SEL_IN, indict))
							inmodel.Custm_Fld_19_Sel_In = GetData (AppConstant.CUSTM_FLD_19_SEL_IN, indict);

						if (IsKeyExist (AppConstant.CUSTM_FLD_20_SEL_IN, indict))
							inmodel.Custm_Fld_20_Sel_In = GetData (AppConstant.CUSTM_FLD_20_SEL_IN, indict);


						model.MobileCheckingSettings = inmodel;
					}


				}

				if (IsKeyExist (AppConstant.ATTENDEE_CUSTOME_FIELD_SETTINGS, dict)) {
					string listArray = "" + GetData (AppConstant.ATTENDEE_CUSTOME_FIELD_SETTINGS, dict);



					JArray injar = dict [AppConstant.ATTENDEE_CUSTOME_FIELD_SETTINGS] as JArray;

					for (int j = 0; j < injar.Count; j++) {

						JObject inobj = injar [j] as JObject;

						AttendeeCustomFieldSettingsModel inmodel = new AttendeeCustomFieldSettingsModel ();

						Dictionary<string,object> indict = inobj.ToObject<Dictionary<string,object>> ();


						if (IsKeyExist (AppConstant.FIELD_NAME, indict))
							inmodel.fieldName = GetData (AppConstant.FIELD_NAME, indict);

						if (IsKeyExist (AppConstant.IS_ON, indict))
							inmodel.isOn = GetData (AppConstant.IS_ON, indict);

						if (IsKeyExist (AppConstant.CATEGORY, indict))
							inmodel.Category = GetData (AppConstant.CATEGORY, indict);
						if (model.AttendeeCustomFieldSettings == null) 
							model.AttendeeCustomFieldSettings = new List<AttendeeCustomFieldSettingsModel> ();

						model.AttendeeCustomFieldSettings.Add (inmodel);


					}
				}

				if (IsKeyExist (AppConstant.HOUSING_CUSTOME_FIELD_SETTINGS, dict)) {
					string listArray = "" + GetData (AppConstant.HOUSING_CUSTOME_FIELD_SETTINGS, dict);

					HousingCustomFieldSettingsModel inmodel = new HousingCustomFieldSettingsModel ();

					JArray injar = dict [AppConstant.HOUSING_CUSTOME_FIELD_SETTINGS] as JArray;

					for (int j = 0; j < injar.Count; j++) {

						JObject inobj = injar [j] as JObject;

						Dictionary<string,object> indict = inobj.ToObject<Dictionary<string,object>> ();


						if (IsKeyExist (AppConstant.FIELD_NAME, indict))
							inmodel.fieldName = GetData (AppConstant.FIELD_NAME, indict);

						if (IsKeyExist (AppConstant.IS_ON, indict))
							inmodel.isOn = GetData (AppConstant.IS_ON, indict);

						if (IsKeyExist (AppConstant.CATEGORY, indict))
							inmodel.Category = GetData (AppConstant.CATEGORY, indict);


						if (model.HousingCustomFieldSettings == null) 
							model.HousingCustomFieldSettings = new List<HousingCustomFieldSettingsModel> ();

						model.HousingCustomFieldSettings.Add (inmodel);

					}
				}

				if (IsKeyExist (AppConstant.VOLUNTEER_CUSTOME_FIELD_SETTINGS, dict)) {
					string listArray = "" + GetData (AppConstant.VOLUNTEER_CUSTOME_FIELD_SETTINGS, dict);

					VolunteerCustomFieldSettingsModel inmodel = new VolunteerCustomFieldSettingsModel ();

					JArray injar = dict [AppConstant.VOLUNTEER_CUSTOME_FIELD_SETTINGS] as JArray;

					for (int j = 0; j < injar.Count; j++) {

						JObject inobj = injar [j] as JObject;

						Dictionary<string,object> indict = inobj.ToObject<Dictionary<string,object>> ();


						if (IsKeyExist (AppConstant.FIELD_NAME, indict))
							inmodel.fieldName = GetData (AppConstant.FIELD_NAME, indict);

						if (IsKeyExist (AppConstant.IS_ON, indict))
							inmodel.isOn = GetData (AppConstant.IS_ON, indict);

						if (IsKeyExist (AppConstant.CATEGORY, indict))
							inmodel.Category = GetData (AppConstant.CATEGORY, indict);


						if (model.VolunteerCustomFieldSettings == null) 
							model.VolunteerCustomFieldSettings = new List<VolunteerCustomFieldSettingsModel> ();

						model.VolunteerCustomFieldSettings.Add (inmodel);

					}
				}

				if (IsKeyExist (AppConstant.ATTENDEE_DETAILS, data)) {
					string listArray = "" + GetData (AppConstant.ATTENDEE_DETAILS, data);

					AttendeeDetailsModel inmodel = new AttendeeDetailsModel ();

					JArray injar =  data [AppConstant.ATTENDEE_DETAILS] as JArray;

					for (int j = 0; j < injar.Count; j++) {

						JObject inobj = injar [j] as JObject;

						Dictionary<string,object> indict = inobj.ToObject<Dictionary<string,object>> ();


						if (IsKeyExist (AppConstant.ID, indict))
							inmodel.ID = GetData (AppConstant.ID, indict);

						if (IsKeyExist (AppConstant.FIRST_NAME, indict))
							inmodel.FirstName = GetData (AppConstant.FIRST_NAME, indict);

						if (IsKeyExist (AppConstant.LAST_NAME, indict))
							inmodel.LastName = GetData (AppConstant.LAST_NAME, indict);

						if (IsKeyExist (AppConstant.CONFIRMATION_CODE, indict))
							inmodel.ConfirmationCode = GetData (AppConstant.CONFIRMATION_CODE, indict);

						if (IsKeyExist (AppConstant.EMAIL, indict))
							inmodel.Email = GetData (AppConstant.EMAIL, indict);

						if (IsKeyExist (AppConstant.GUESTS, indict))
							inmodel.Guests = GetData (AppConstant.GUESTS, indict);

						if (IsKeyExist (AppConstant.PHONE_NUMBER, indict))
							inmodel.PhoneNumber = GetData (AppConstant.PHONE_NUMBER, indict);

						if (IsKeyExist (AppConstant.CITY, indict))
							inmodel.City = GetData (AppConstant.CITY, indict);

						if (IsKeyExist (AppConstant.STATE, indict))
							inmodel.State = GetData (AppConstant.STATE, indict);

						if (IsKeyExist (AppConstant.VALIDITY, indict))
							inmodel.Validity = GetData (AppConstant.VALIDITY, indict);

						if (IsKeyExist (AppConstant.NOTES, indict))
							inmodel.Notes = GetData (AppConstant.NOTES, indict);

						if (IsKeyExist (AppConstant.STATUS, indict))
							inmodel.Status = GetData (AppConstant.STATUS, indict);

						if (IsKeyExist (AppConstant.EVENT_ID, indict))
							inmodel.EventId = GetData (AppConstant.EVENT_ID, indict);

						if (IsKeyExist (AppConstant.ATTENDEE_TYPE_ID,indict))
							inmodel.AttendeeTypeId = GetData (AppConstant.ATTENDEE_TYPE_ID, indict);

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_1,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_1] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField1 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_2,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_2] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField2 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_3,dict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_3] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField3 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_4,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_4] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField4 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_5,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_5] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField5 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_6,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_6] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField6 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_7,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_7] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField7 = user;

						}
						if (IsKeyExist (AppConstant.CUSTOME_FIELD_8,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_8] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField8 = user;

						}
						if (IsKeyExist (AppConstant.CUSTOME_FIELD_9,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_9] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField9 = user;

						}
						if (IsKeyExist (AppConstant.CUSTOME_FIELD_10,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_10] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField10 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_11,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_11] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField11 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_12,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_12] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField12 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_13,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_13] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField13 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_14,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_14] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField14 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_15,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_15] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField15 = user;

						}

						if (IsKeyExist (AppConstant.CUSTOME_FIELD_16,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_16] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField16 = user;

						}
						if (IsKeyExist (AppConstant.CUSTOME_FIELD_17,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_17] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField17 = user;

						}
						if (IsKeyExist (AppConstant.CUSTOME_FIELD_18,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_18] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField18 = user;

						}
						if (IsKeyExist (AppConstant.CUSTOME_FIELD_19,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_19] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField19 = user;

						}
						if (IsKeyExist (AppConstant.CUSTOME_FIELD_20,indict)) {

							JObject jObj = indict [AppConstant.CUSTOME_FIELD_20] as JObject;

							Dictionary<string, object> dataDic = jObj.ToObject<Dictionary<string, object>> ();

							CustomFieldModel user = new CustomFieldModel ();

							if (IsKeyExist (AppConstant.LABEL, dataDic))
								user.Label = GetData (AppConstant.LABEL, dataDic);

							if (IsKeyExist (AppConstant.VALUE, dataDic))
								user.Value = GetData (AppConstant.VALUE, dataDic);

							if (IsKeyExist (AppConstant.IS_ENABLED,dataDic))
								user.IsEnabled = GetData (AppConstant.IS_ENABLED, dataDic);

							inmodel.CustomField20 = user;

						}


						model.attendeeDetails = inmodel;

					}
				}


				if (IsKeyExist (AppConstant.CATEGORY_TYPES, data)) {
					string listArray = "" + GetData (AppConstant.CATEGORY_TYPES, data);




					JArray injar =  data [AppConstant.CATEGORY_TYPES] as JArray;

					for (int j = 0; j < injar.Count; j++) {

						CategoryTypesModel inmodel = new CategoryTypesModel ();

						JObject inobj = injar [j] as JObject;


						Dictionary<string,object> indict = inobj.ToObject<Dictionary<string,object>> ();

						if (IsKeyExist (AppConstant.CHILDREN, indict)) {
							string childArray = "" + GetData (AppConstant.CHILDREN, indict);

							ChildrenModel cModel = new ChildrenModel();

							JArray cJar = indict [AppConstant.CHILDREN] as JArray;

							for (int c = 0; c < cJar.Count; c++) {

								JObject cobj = cJar [c] as JObject;

								Dictionary<string,object> cdict = inobj.ToObject<Dictionary<string,object>> ();


								if (IsKeyExist (AppConstant.ID, cdict))
									cModel.ID = GetData (AppConstant.ID, cdict);

								if (IsKeyExist (AppConstant.TEXT, cdict))
									cModel.Text = GetData (AppConstant.TEXT, cdict);

								inmodel.Children = cModel;

							}
						}

						if (IsKeyExist (AppConstant.ID, indict))
							inmodel.ID = GetData (AppConstant.ID, indict);

						if (IsKeyExist (AppConstant.TEXT, indict))
							inmodel.Text = GetData (AppConstant.TEXT, indict);


						if (model.categoryTypes == null) 
							model.categoryTypes = new List<CategoryTypesModel> ();

						model.categoryTypes.Add (inmodel);

					}
				}

			}

			return model;
			#endregion
		}

		#region get login details
		public static CheckInWithConfirmationCodeModel GetCheckInDetails(Dictionary<string,object> dataDic)
		{
			CheckInWithConfirmationCodeModel modal = new CheckInWithConfirmationCodeModel ();

			if (IsKeyExist (AppConstant.SUCCESS, dataDic)) 
				modal.success = GetData (AppConstant.SUCCESS, dataDic);

			if (IsKeyExist (AppConstant.MESSAGE, dataDic))
				modal.message = GetData (AppConstant.MESSAGE, dataDic);


			return modal;
		}
		#endregion
	}
}
