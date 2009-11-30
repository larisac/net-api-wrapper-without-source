using System;
using System.Collections.Generic;
using System.Text;

namespace CampaignMonitorAPISample
{
    public class List
    {
        internal static void Create()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string clientID = "xxxxxxxxxxxClientIDxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.Create(apiKey, clientID, "New API List", "", true, "");

            if (result.Code != 0)
                Console.WriteLine("Error creating new subscriber list : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("The new subscriber list was successfully created. It's ID is " + result.ReturnObject);
        }

        internal static void Update()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string listID = "xxxxxxxxxxxxListIDxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.Update(apiKey, listID, "New API List1", "", true, "");

            if (result.Code != 0)
                Console.WriteLine("Error updating subscriber list : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("The subscriber list was successfully updated.");
        }

        internal static void GetDetail()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string listID = "xxxxxxxxxxxxListIDxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.GetDetail(apiKey, listID);

            if (result.Code != 0)
                Console.WriteLine("Error retrieving the subscriber list details : " + result.Code.ToString() + " - " + result.Message);
            else
            {
                Console.WriteLine("ListID : " + result.ReturnObject.ListID);
                Console.WriteLine("Title : " + result.ReturnObject.Title);
                Console.WriteLine("UnsubscribePage : " + result.ReturnObject.UnsubscribePage);
                Console.WriteLine("ConfirmOptIn : " + result.ReturnObject.ConfirmOptIn);
                Console.WriteLine("ConfirmationSuccessPage : " + result.ReturnObject.ConfirmationSuccessPage);
            }
        }

        internal static void GetStats()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string listID = "xxxxxxxxxxxxListIDxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.GetStats(apiKey, listID);

            if (result.Code != 0)
                Console.WriteLine("Error retrieving the subscriber list statistics : " + result.Code.ToString() + " - " + result.Message);
            else
            {
                Console.WriteLine("Total active subscribers: " + result.ReturnObject.TotalActiveSubscribers);
                Console.WriteLine("New active subscribers today: " + result.ReturnObject.NewActiveSubscribersToday);
                Console.WriteLine("New active subscribers yesterday: " + result.ReturnObject.NewActiveSubscribersYesterday);
                Console.WriteLine("New active subscribers this week: " + result.ReturnObject.NewActiveSubscribersThisWeek);
                Console.WriteLine("New active subscribers this month: " + result.ReturnObject.NewActiveSubscribersThisMonth);
                Console.WriteLine("New active subscribers this year: " + result.ReturnObject.NewActiveSubscribersThisYear);
                Console.WriteLine("Total unsubscribes: " + result.ReturnObject.TotalUnsubscribes);
                Console.WriteLine("Unsubscribes today: " + result.ReturnObject.UnsubscribesToday);
                Console.WriteLine("Unsubscribes yesterday: " + result.ReturnObject.UnsubscribesYesterday);
                Console.WriteLine("Unsubscribes this week: " + result.ReturnObject.UnsubscribesThisWeek);
                Console.WriteLine("Unsubscribes this month: " + result.ReturnObject.UnsubscribesThisMonth);
                Console.WriteLine("Unsubscribes this year: " + result.ReturnObject.UnsubscribesThisYear);
                Console.WriteLine("Total deleted: " + result.ReturnObject.TotalDeleted);
                Console.WriteLine("Deleted today: " + result.ReturnObject.DeletedToday);
                Console.WriteLine("Deleted yesterday: " + result.ReturnObject.DeletedYesterday);
                Console.WriteLine("Deleted this week: " + result.ReturnObject.DeletedThisWeek);
                Console.WriteLine("Deleted this month: " + result.ReturnObject.DeletedThisMonth);
                Console.WriteLine("Deleted this year: " + result.ReturnObject.DeletedThisYear);
                Console.WriteLine("Total bounces: " + result.ReturnObject.TotalBounces);
                Console.WriteLine("Bounces today: " + result.ReturnObject.BouncesToday);
                Console.WriteLine("Bounces yesterday: " + result.ReturnObject.BouncesYesterday);
                Console.WriteLine("Bounces this week: " + result.ReturnObject.BouncesThisWeek);
                Console.WriteLine("Bounces this month: " + result.ReturnObject.BouncesThisMonth);
                Console.WriteLine("Bounces this year: " + result.ReturnObject.BouncesThisYear);
            }
        }

        internal static void Delete()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string listID = "xxxxxxxxxxxxListIDxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.Delete(apiKey, listID);

            if (result.Code != 0)
                Console.WriteLine("Error deleting subscriber list : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("The subscriber list was successfully deleted.");
        }

        internal static void CreateCustomField()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string listID = "xxxxxxxxxxxxListIDxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.CreateCustomField(apiKey, listID, "NewCustomField", CampaignMonitorAPIWrapper.CampaignMonitorAPI.SubscriberFieldDataType.MultiSelectOne, "op1||op2");

            if (result.Code != 0)
                Console.WriteLine("Error creating custom field : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("The custom field was successfully created");
        }

        internal static void GetCustomFields()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string listID = "xxxxxxxxxxxxListIDxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.GetCustomFields(apiKey, listID);

            if (result.Code != 0)
                Console.WriteLine("Error getting the lists custom fields : " + result.Code.ToString() + " - " + result.Message);
            else if (result.ReturnObject.Count == 0)
                Console.WriteLine("There are no custom fields for this list");
            else
                foreach (var cf in result.ReturnObject)
                {
                    Console.WriteLine("Key : " + cf.Key);
                    Console.WriteLine("FieldName : " + cf.FieldName);
                    Console.WriteLine("DataType : " + cf.DataType);

                    foreach (var option in cf.FieldOptions)
                    {
                        Console.WriteLine("   Option : " + option);
                    }

                    Console.WriteLine("---------------------------------------");
                }
        }

        internal static void DeleteCustomField()
        {
            string apiKey = "xxxxxxxxxxxxApiKeyxxxxxxxxxxxxxx";
            string listID = "xxxxxxxxxxxxListIDxxxxxxxxxxxxxx";

            var result = CampaignMonitorAPIWrapper.List.DeleteCustomField(apiKey, listID, "[NewCustomField]");

            if (result.Code != 0)
                Console.WriteLine("Error deleting custom field : " + result.Code.ToString() + " - " + result.Message);
            else
                Console.WriteLine("The custom field was successfully deleted");
        }
    }
}
