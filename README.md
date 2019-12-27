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
3. Navigate to [localhost:5001](https://localhost:5001)

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

This was created as an assignment and is thus unsupported.