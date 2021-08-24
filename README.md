# Canon Calculator
 A simple tool to evaluate some parameters from the output file from the Canon imagePROGRAPH series printers that supports the Canon Accounting Manager. This tool is sponsored by [BSLprints](http://bslprints.com) and released under BSD Open Source license. You are free to modify and redistribute this program as you see fit.
 
 ![image](https://user-images.githubusercontent.com/49788602/130698230-b22b7a12-7155-40f7-81ae-9743dbd7090d.png)

## Compiling
You should be able to easily compile this application in Visual Studio 2019's C# module without any special dependencies or requirements.

## Setup

1. Make sure you have Canon Accounting Manager installed and set up. If needed you can get the latest version [here](https://www.usa.canon.com/internet/portal/us/home/support/details/professional-large-format-printers/professional-photo-fine-art/imageprograf-pro-2100?subtab=downloads-software) (it is the same software for all supported printers).


2. Open the CSV export settings:

![image](https://user-images.githubusercontent.com/49788602/130696893-495bb782-484f-4ae8-a4d6-1df53a3c7100.png)


3. Check _exactly_ the following options: Cost, Printing Results, Media Type, Paper Consumed, Print Quality, all the rest until the end of the list and click OK (a future version will be more flexible in this setting):

![image](https://user-images.githubusercontent.com/49788602/130698477-f507ec9f-e2d7-4253-af01-91b4a9f552ed.png)
![image](https://user-images.githubusercontent.com/49788602/130698518-0e3ab65c-8ee2-4eb9-9e4d-cd0261a87647.png)
![image](https://user-images.githubusercontent.com/49788602/130698540-9e478eee-2ccc-4f6a-b683-fecc8f87f261.png)


4. Open Tools->Preferences

![image](https://user-images.githubusercontent.com/49788602/130698641-c5268731-a634-4df4-ac52-56abd4f6ed65.png)


5. Change Print Jobs Shown Per Page to its highest value and click ok (this is not a strict requirement but it makes it easier to export more logs at once)

![image](https://user-images.githubusercontent.com/49788602/130698707-82bdb10b-bc0f-47e4-abbf-d636ebbc16eb.png)


6. Select the first line in job log table by clicking on it

![image](https://user-images.githubusercontent.com/49788602/130698801-56cf78c9-4066-43e8-b1fd-e35c80dd0e7e.png)


7. Press Ctrl + A to select all logs in the list

![image](https://user-images.githubusercontent.com/49788602/130698912-23bc62dd-200e-46a5-9e69-b88333d5a776.png)


8. Right click the list of selected jobs and choose Export Job Cost Data

![image](https://user-images.githubusercontent.com/49788602/130699088-6930c07a-e5e4-4173-bc8f-036bbb2f6f7c.png)


9. Save the CSV file somewhere you can remember
10. Optionally repeat steps 6-9 for each page in your log
11. Open CanonCalculator utility and select the CSV file(s) you created and the location to save the new data and click Generate

