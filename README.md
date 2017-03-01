# OneSignal Client
.NET REST Client for the OneSignal Push API


## nuGet Install
    Install-Package OneSignal.Client

## Sample Usage

List Apps:

    var apiKey = "A3DhSfB6VsHdYTgxNy85NGU3LGScSHCcMzFmNDS5YjRiODU5";
    using (var client = new OneSignalClient(apiKey))
    {
        var apps = await client.Apps.View();
    }

Create a Notification:

    var apiKey = "A3DhSfB6VsHdYTgxNy85NGU3LGScSHCcMzFmNDS5YjRiODU5";
    using (var client = new OneSignalClient(apiKey))
    {
        var apps = await client.Notifications.Create(new Notification());
    }