# OneRoster.NET

A simple client library for the OneRoster Spec, supporting versions 1.1 and 1.2.  Only rostering calls are supported.  Grade book has not been implemented.
>Note: The OneRoster 1.2 specification has not yet been finalized.  OneRoster.NET's implementation may change in the future to match the final spec once it's released.

# Features
- Auto deserialization to dto's
- Synchronous calls
- Asynchronous calls
- Raw calls to view response content and headers (for troubleshooting or to deseralize using your own objects)
- Intellisense comments

## Installation
- Nuget CLI
`Install-Package OneRoster.NET`

- Nuget GUI Package Manager
`Search for OneRoster`


## Usage
**V1P1** - Replace baseUrl, consumerKey, and consumerSecret with appropriate values
```csharp
using (var ora = new OneRosterApi().V1p1("baseUrl", "consumerKey", "consumerSecret"))
{
	//sync
	var students = ora.StudentsManagement.GetAllStudents();
	//async
	var studentsAsync = await ora.StudentsManagement.GetAllStudentsAsync();
	//raw
	var studentsRaw = ora.StudentsManagement.GetAllStudentsRaw();
}
```

**V1P2** - Replace tokenUrl, baseUrl, clientId, and clientSecret with appropriate values
```csharp
using (var ora = new OneRosterApi().V1p2("tokenUrl","baseUrl", "clientId", "clientSecret"))
{
	//sync
	var students = ora.StudentsManagement.GetAllStudents();
	//async
	var studentsAsync = await ora.StudentsManagement.GetAllStudentsAsync();
	//raw
	var studentsRaw = ora.StudentsManagement.GetAllStudentsRaw();
}
```


## Parameters
```csharp
var students = ora.StudentsManagement.GetAllStudents(new OneRoster.NET.v1p2.ApiParameters { Limit = 10, Offset = 100 });
```
[View the offical spec for more details.](https://www.imsglobal.org/oneroster-v11-final-specification)

## Available Managements
- AcademicSessionsManagement
- ClassesManagement
- CoursesManagement
- DemographicsManagement
- EnrollmentsManagement
- GradingPeriodsManagement
- OrgsManagement
- SchoolsManagement
- StudentsManagement
- TeachersManagement
- TermsManagement
- UsersManagement

