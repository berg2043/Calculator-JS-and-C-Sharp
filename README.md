# HTML Calculator with .NET Back End

## Description
_Durration: 2 days_

This is a browser based calculator that uses javascript on the front end and 
`.NET` on the back end.  Jquery is used to manipulate the DOM, and data is stored
in local memory through `Microsoft.EntityFrameworkCore.InMemory`. 

## Prerequisites

* .NET Core
* NuGet

## Installation

1. Run `dotnet build` to build the project and it's dependencies
2. Run `dotnet ./bin/Debug/netcoreapp3.0/Calculator.Api.dll` for powershell \
`dotnet ./bin/Debug/netcoreapp3.0/Calculator.Api.dll \`\
    `> Calculator.Api.log &` for bash/terminal
3. Navigate to [localhost:5001](localhost:5001)

## Usage

The calculator only takes two arguments and does basic math.  Buttons are disabled
after you've clicked an operator.  Pressing `=` calculates the math problem displayed.

`C` clears the current entry.

A history is displayed under the calculator.  Clicking on a previous entry re-runs
that math problem.

`Clear History` prompts the user to confirm is they want to clear the history.  If
confirmed, the history on the server is cleared.

## Built With

Javascript
* jquery

C#
* .NET core
* `ASP.NET`
* kestrel

## Support

If you have nay suggestions or issues, please e-mail me at phillipb1991@msn.com

## Assignment Questions

Describe briefly (3-5 sentences), at a high-level, what this technology is used for or good add.
- C# is used in many areas.  It's the language used for building `.NET` applications
which can be used in numerous fields including game development.
The main areas are windows store apps, windows client apps, office apps, 
enterprise apps, webapps, mobile apps, and backend services.  It works similar to
 Java. 

Does it replace or enhance a part of our Prime full-stack?
- From my understanding, it can replace all the parts of the full stack, but
I used it for the backend.

What resources did you find most useful in learning? (Provide links & short descriptions)
- [Codecademy](https://www.codecademy.com/learn/learn-c-sharp): Provided me an intro into C#
- [Microsoft's Create a web API with ASP.NET Core Exercise](https://docs.microsoft.com/en-us/learn/modules/build-web-api-net-core/):
taught me how to spin up an `ASP.NET` server
- [Microsoft's .net Documetation](https://docs.microsoft.com/en-us/dotnet/?view=netframework-4.8): 
provided resources to lookup how methods worked
- [Google](https://www.google.com) and [Stack Overflow](https://www.stackoverflow.com):
answered questions I had on the way

What did you find most challenging?
- c# is type safe, so it took a while to get used to declaring the variable
type before defining it.  After that, getting the server to spin up took quite a
while.  I didn't realize it had been up for a while, but didn't have a default
page for localhost:5001.  The final hurdle was getting ajax to ineract with the
post route properly.  I recieved a lot of 415 and 400 responses for many hours.

What would you do/learn next with this technology if you had more time?
- I would make the app restful.  Right now, the post is returning the latest answer.
After that, I'd learn what all the System and Microsoft dependencies are doing.
I reasoned what a lot of the code was doing, but much of it is just Cargo Cult thinking
from the API tutorial.