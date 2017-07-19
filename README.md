# AppMobileDevOps
This is an example on how to integrate Mobile Center Analytics and Crashes to Xamarin.Forms application.

Mobile Center can track your application events, logs, and crashes which is essential for your app's growth and rating.

How to use:
<ol>
  <li>
    Add Nuget Packages(using Manage Nuget Packages) and add the following codes that you want to track by Mobile Center:<br>
    <pre><code class='language-cs'>
    using Microsoft.Azure.Mobile;
    using Microsoft.Azure.Mobile.Analytics;
    using Microsoft.Azure.Mobile.Crashes;
    </code></pre>
  </li>    
  <li>
      Add your Android key from Mobile Center for Xamarin.Forms in App.xaml.cs<br>
      <pre><code class='language-cs'>
      protected override void OnStart()
      {
          // Handle when your app starts
          MobileCenter.Start($"android={androidKey};", typeof(Analytics), typeof(Crashes));
      }
      </code></pre>
  </li>
  <li>
      Add Tracking Event:<br>
      <pre><code class='language-cs'>
      var param = new Dictionary<string, string>();
      param.Add("Blue button", "Button");
      Analytics.TrackEvent("Blue button was clicked", param);
      </code></pre>
      <br><br>
      Add Crash Event:<br>
      <pre><code class='language-cs'>bool didAppCrash = await Crashes.HasCrashedInLastSessionAsync();</code></pre>
  </li>
</ol>
<h3>Mobile Mobile Center</h3>
<b>Crashes</b><br>
<img src="https://raw.githubusercontent.com/makubex88/AppMobileDevOps/master/Crashes.png" style="width:100px;height:100px;"/><br>
<b>Analytics-Overview</b><br>
<img src="https://raw.githubusercontent.com/makubex88/AppMobileDevOps/master/Analytics-Overview.png" style="width:100px;height:100px;"/><br>
<b>Analytics-Events</b><br>
<img src="https://raw.githubusercontent.com/makubex88/AppMobileDevOps/master/Analytics-Events.png" style="width:100px;height:100px;"/><br>
<b>Analytics-LogFlow</b><br>
<img src="https://raw.githubusercontent.com/makubex88/AppMobileDevOps/master/Analytics-LogFlow.png" style="width:100px;height:100px;"/><br>
<h3>Mobile Screen</h3>
<img src="https://raw.githubusercontent.com/makubex88/AppMobileDevOps/master/Initial%20Screen.png" style="width:100px;height:100px;"/><br>
<img src="https://raw.githubusercontent.com/makubex88/AppMobileDevOps/master/BlueBtnClicked.png" style="width:500px;height:500px;"/>

