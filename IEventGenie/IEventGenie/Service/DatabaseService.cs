using System;
using SQLite;
using System.Collections.Generic;
using System.IO;

namespace IEventGenie
{
	public class DatabaseService
	{
		private readonly SQLiteAsyncConnection db;

		public DatabaseService ()
		{
			string DbName = "database.db";
			var dbPath = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), DbName);
			db = new SQLiteAsyncConnection (dbPath);
		}

		private void CreateTables()
		{
			db.CreateTableAsync<BeaconNotificationModel>();
		}

		public void InsertNotification(BeaconNotificationModel notificationModel)
		{
			if (notificationModel == null)
				throw new ArgumentNullException ("notificationModel");
			
				try{
					db.InsertAsync(notificationModel);
				}catch(Exception e)
				{
					System.Diagnostics.Debug.WriteLine (""+e.StackTrace);
				}
				
		}


		public BeaconNotificationModel GetNotificationDetails ()
		{
			try{
				List<BeaconNotificationModel> noti = db.Table<BeaconNotificationModel> ().ToListAsync().Result;
				return noti.Count > 0 ? noti[noti.Count - 1] : new BeaconNotificationModel();
			}catch(Exception e)
			{
				return new BeaconNotificationModel ();
			}
		}



	}

}

