# Animal Sanctuary

## By Lois Choi

#### _This is dedicated web site to post our travel experiences all over the world., 10.10.17_


## Description

_This is dedicated web site to post our travel experiences all over the world._

|| Behavior  | Input  | Output  |
|---|---|---|---|
|1| User may view a list of all animals on the Home/Index view  | Click `Home` in navigation bar  | View displays buttons with animal name, species|
|2| User may view a animals's details. | Click `Details`  | View displays all animal details |
|3| User may view a list of all veterinarians | Click `Veterinarians`| View displays list of veterinarians name|
|4| User may view veterinarian's details. | Click `Details` | View displays veterinarians details |
|5| User may be able to add a new veterinarian | Click `Add new veterinarian` | View displays form to add new vet - new vet is listed in index view |
|6| User may add a new animal and link it to its veterinarian | Click `Add new animal` | View displays form to add new animal - dropdown to select vet |


## Setup/Installation Requirements

* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [Mono](http://www.mono-project.com/download/)_
* _Download and install [MAMP](https://www.mamp.info/en/)_
* _Set MySQL Port to 3306_
* _Clone repository_


## Technologies Used
* _C#_
* _.NET_
* _MVC_
* _Entity Framework_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_
* _[MySQL](https://www.mysql.com/)_

### License

Copyright (c) 2017 **_Lois Choi**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*


### ASP.Net
#### Add Packages
* Microsoft.AspNetCore.Mvc - Version 1.1.2
* Microsoft.EntityFrameworkCore - Version 1.1.2
* Pomelo.EntityFrameworkCore.MySql - Version 1.1.2
* Microsoft.AspNetCore.StaticFiles - Version 1.1.2
* Microsoft.AspNetCore - Version 1.1.2

### Migration
#### Add Packages
* Microsoft.EntityFrameworkCore.Design - Version 1.1.2

#### Add to .csproj
```
<ItemGroup>
  <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
</ItemGroup>
```
If missing, add:
```
<ItemGroup>
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="1.1.2" />
</ItemGroup>
```

#### Commands in terminal or VS Package Console (Windows only)
* Right click on solution file, `Build` project
* `Start Server` in MAMP
* `dotnet restore` (keep running restore if you come across errors)
* `dotnet ef migrations add Initial` (Initial can be any name of your migration, like a commit message)
* `dotnet ef database update`