# HTML_Previewer

HTML_Previewer is a webapplication for storing html code.
## Installation

1. Create a new ASP.NET Core Web App
2. Pull from repository
3. Install the following NuGet packages:
- Microsoft.EntityFrameworkCore.Design version 3.1.20
- Microsoft.EntityFrameworkCore.SqlServer version 3.1.20
- Microsoft.EntityFrameworkCore.Tools version 3.1.20
- Microsoft.VisualStudio.Web.CodeGeneration.Design 3.1.5
4. Apply migrations
5. Run 

## Usage
To start:
1. From the home screen click the green button "Start Editor" or select the Editor tab
2. You get redirected to page with list of current HTML saved in the app

1. Create New
    1. Click on add new to add new html code
    2. Click on run to preview the html code in the green box on the left 
    3. Click on save to save the code in the database

2. Share a link: 
    1. Create a new entry
    2. Save it
    3. Find your entry in the list and right click on View Details / Share link.
    4. Click on copy link address 
    5. Alternatively: left click and copy link from the browser address bar

3. Check for duplicates:
    1. Create an entry
    2. Save it
    3. Click on the button "Duplicates Check" on the "HTML Submissions" page
    4. If only that entry remains - no duplicates. If there is another one, it is a duplicate. 
    5. Click on the button "Clear Check" to return to the full submissions list

4. Preview HTML:
    1. Click on Create New or Edit links
    2. Click on the blue button "Run"

5. Delete Submission:
    1. Go to submissions list page
    2. Select "Delete" in the actions column for the corresponding submission
