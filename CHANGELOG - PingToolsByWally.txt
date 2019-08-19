Last Updated: 2/22/2018 2:30PM
Current version V1.4
First version date: 2/15/2018 1:00AM

To change on each version change:
-Last Updated labels on all 3 forms
-Main Form text property to reflect new version number
-Make copy of the project folder and put in repository as new version
-Build/Run the program in Visual Studio so the .exe file is built as newest version
-Copy newest version of the .exe to the base folder of the repository and rename it with proper version number

Things to implement in V1.5:
-Figure out how to embed iperf3.exe (and accompanying .dll file) in program somehow and launch it from Main Form
-Do the same as above but with the DNS Benchmark Tool (somehow import file to the Resources and run it that way)
-Change the icon of the program as viewed from a File Browser
-Make the text in the Tool Information Form more readable
-Change colors of all forms to the same color
-Remake the icon so it's decent looking (hopefully just have to edit it inside VB studio, or edit in paint and paste it in)
-Add in NTP servers, and recheck Comcast nodes to see what needs to be added

-----CHANGELOG-----
Changelog from V1.3.1 to V1.4:
-Added Internet Options link label that opens the Internet Options Control Panel window
-Added Network Interfaces link label that opens the Network Interfaces Control Panel window
-Added Windows Firewall link label that opens the Windows Firewall Control Panel window
-Moved "Last Updated" label above buttons to fill some of the white space created when adding the new Link Labels
-Added new Form containing IP settings to change IP to either custom Static or DHCP, accessed via the "IP settings" button on the main form
-Set the input boxes on the IPwindow form to have common values that the user can change if need be
-Added a Link Label on the Tool Information Form that opens Command Prompt
***You now have to run the program as an administrator so the IPwindow netsh command will work
-Added label stating program must be run as Admin to the IPwindow
-Enabled Minimize buttons on all forms
-Widened the IP Settings form so the minimize button didn't cut off the text in the title bar
-Before the custom DNS servers are added, it deletes ALL dns servers currently set on the computer
-Added custom Secondary DNS input text box in IP window. If it is NOT empty, then it will add a secondary DNS using netsh
-Added a pop-up message when you launch the IP window form to let you know that you MUST run as admin to change the IP address
-Made it so the icon that appears in the Task Bar is a custom one, had to enable the Icon in the Main form for this to work
-Added icon to the IP window form as well, also had to enable the Icon
-In the External Links form, swapped places of the DownDetector and DownForEveryoneOrJustMe link labels so they're in alphabetical order
-Changed icon to something that looks more professional. Rebuilt program, current version is still V1.4
-Changed background color of all forms to the default "control" color

Changelog from V1.3 to V1.3.1:
-Made the IPv4 radio button checked on startup

Changelog from V1.2 to V1.3:
-Restructured code slightly and added comments
-Set the Tool Information Form scroll default position to leftmost when shown

Changelog from V1.1 to V1.2:
-Added changelog comment block in Main Form code
-Added "Last Updated" labels on all 3 forms
-Added Command Prompt LinkLabel that opens Command Prompt
-Added Notepad LinkLabel that opens Notepad
-Sorted the newly added LinkLabels on the Main Form alphabetically
-Added External Links Form which contains a LOT of external links to status pages, outage reports, speed testing websites, IP location websites, and misc links
-Added Tool Information Form which contains information about all the tools used in the Main Form as well as some not used in the Main Form but available in Windows by default
-Changed background color of all Forms to "Scroll Bar"
-Added a LOT of domains to the "Websites" combo box and restructured to make easier to find; Some domains (clients1-6.google.com) resolved to the same address