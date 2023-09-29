using System;
using System.Reflection;

//ref link:
// GAC - GLOBAL Assembly Cache

// SH Fusion.DLL - for knowledge in assembly files plugin in GAC

//------------GAC STURCTURE-----------
//C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Farm\v4.0_1.0.0.0__2f4bcac2715a74ca\Farm.dll
//C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Farm\v4.0_1.0.0.0__439d39c99d560b47\Farm.dll

// 1 - Name -   Farm
// 2 - Version  - v4.0_1.0.0.0
// 3 - Public Key Token - 2f4bcac2715a74ca
// 4 - Culture

/*---------------------------CMD---------------------------------------
 * 
C:\Users\sunny\source\repos\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache

28/09/2023  10:52 am    <DIR>          .
28/09/2023  10:52 am    <DIR>          ..
28/09/2023  10:52 am             2,581 .gitattributes
28/09/2023  10:52 am             6,585 .gitignore
28/09/2023  10:56 am    <DIR>          DotNet Global Assembly Cache
27/09/2023  03:38 pm             1,190 DotNet Global Assembly Cache.sln
               3 File(s)         10,356 bytes
               3 Dir(s)  487,886,749,696 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache>cd DotNet Global Assembly Cache

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  10:56 am    <DIR>          .
28/09/2023  10:56 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  10:56 am               535 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               3 File(s)          3,130 bytes
               5 Dir(s)  487,874,166,784 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>sn -k KulpotKey.key

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to KulpotKey.key

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:02 am    <DIR>          .
28/09/2023  11:02 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  10:58 am             2,040 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               4 File(s)          5,231 bytes
               5 Dir(s)  487,875,502,080 bytes free


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:03 am    <DIR>          .
28/09/2023  11:03 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:03 am             3,584 Farm.dll
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:02 am             3,141 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               5 File(s)          9,916 bytes
               5 Dir(s)  487,875,133,440 bytes free

-----------gacutil -i Farm.dll-------------Fail
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>gacutil -i Farm.dll
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Failure adding assembly to the cache: Administrator permissions are needed to use the selected options. Use an administrator command prompt to complete these tasks.
-------------------------------------------------
-----------OVERWRITE: Farm.dll----------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /t:library /out:Farm.dll /keyfile:KulpotKey.key Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:06 am    <DIR>          .
28/09/2023  11:06 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:07 am             4,096 Farm.dll
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:06 am             4,785 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               5 File(s)         12,072 bytes
               5 Dir(s)  487,880,777,728 bytes free

------------------CDM Admin Required-----------
search Developer Command Prompt for VS
----------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>gacutil -i Farm.dll
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Assembly successfully added to the cache

--------------CREATED---------For Bill.exe-----------------
//[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooooooo version 1");
//    }
//}

class MainClass
{
    static void Main()
    {

    }
}
---------------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /r:Farm.dll /out:Bill.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

--------------------CREATED-------For Jerry.exe----------------

//[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooooooo version 1");
//    }
//}

//class MainClass
//{
//    static void Main()
//    {

//    }
//}

    class MainClass
{
    static void Main()
    {
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
    }
}

-------------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /r:Farm.dll /out:Jerry.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:38 am    <DIR>          .
28/09/2023  11:38 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:07 am             4,096 Farm.dll
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:38 am             7,782 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               7 File(s)         23,261 bytes
               5 Dir(s)  487,342,755,840 bytes free

----------------------Erase Farm.dll-------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>erase Farm.dll

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:41 am    <DIR>          .
28/09/2023  11:41 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:41 am             9,205 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               6 File(s)         20,588 bytes
               5 Dir(s)  487,340,498,944 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Bill.exe
Moooooooooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Jerry.exe
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1

---------------CREATED--------for recreation of deleted Farm.dll--------------
[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooooooo version 1");
//    }
//}

//class MainClass
//{
//    static void Main()
//    {

//    }
//}

//class MainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//    }
//}

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Kulpots moooooooooooo version 1");
    }
}
------------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /t:library /out:Farm.dll /keyfile:Kulpotkey.key Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:50 am    <DIR>          .
28/09/2023  11:50 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:49 am             4,096 Farm.dll
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:50 am            11,429 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               7 File(s)         26,908 bytes
               5 Dir(s)  487,339,724,800 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>bill.exe
Moooooooooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>jerry.exe
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1

-----------------Unistall gacutil -u Farm---------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>gacutil -u Farm
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.


Assembly: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=439d39c99d560b47, processorArchitecture=MSIL
Uninstalled: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=439d39c99d560b47, processorArchitecture=MSIL
Number of assemblies uninstalled = 1
Number of failures = 0

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:53 am    <DIR>          .
28/09/2023  11:53 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj28/09/2023  11:49 am             4,096 Farm.dll
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:53 am            13,689 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               7 File(s)         29,168 bytes
               5 Dir(s)  487,336,415,232 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Bill.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Jerry.exe
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
-----------------------------------------------------------------------------
--------------------DotNet GAC Folder-------------START------------

C:\Users\sunny\source\repos\DotNet GAC Folder>cd DotNet GAC Folder

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder

28/09/2023  12:08 pm    <DIR>          .
28/09/2023  12:08 pm    <DIR>          ..
28/09/2023  11:58 am               189 App.config
28/09/2023  11:58 am    <DIR>          bin
28/09/2023  11:58 am             2,384 DotNet GAC Folder.csproj
28/09/2023  11:49 am             4,096 Farm.dll
28/09/2023  11:02 am               596 KulpotKey.key
28/09/2023  11:58 am    <DIR>          obj
28/09/2023  12:07 pm            15,209 Program.cs
28/09/2023  11:58 am    <DIR>          Properties
               5 File(s)         22,474 bytes
               5 Dir(s)  487,332,642,816 bytes free

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>sn -k YourKey.snk

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to YourKey.snk

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder

28/09/2023  12:11 pm    <DIR>          .
28/09/2023  12:11 pm    <DIR>          ..
28/09/2023  11:58 am               189 App.config
28/09/2023  11:58 am    <DIR>          bin
28/09/2023  11:58 am             2,384 DotNet GAC Folder.csproj
28/09/2023  11:49 am             4,096 Farm.dll
28/09/2023  11:02 am               596 KulpotKey.key
28/09/2023  11:58 am    <DIR>          obj
28/09/2023  12:11 pm            16,498 Program.cs
28/09/2023  11:58 am    <DIR>          Properties
28/09/2023  12:10 pm               596 YourKey.snk
               6 File(s)         24,359 bytes
               5 Dir(s)  487,331,520,512 bytes free

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>erase Farm.dll

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder

28/09/2023  12:12 pm    <DIR>          .
28/09/2023  12:12 pm    <DIR>          ..
28/09/2023  11:58 am               189 App.config
28/09/2023  11:58 am    <DIR>          bin
28/09/2023  11:58 am             2,384 DotNet GAC Folder.csproj
28/09/2023  11:02 am               596 KulpotKey.key
28/09/2023  11:58 am    <DIR>          obj
28/09/2023  12:11 pm            17,368 Program.cs
28/09/2023  11:58 am    <DIR>          Properties
28/09/2023  12:10 pm               596 YourKey.snk
               5 File(s)         21,133 bytes
               5 Dir(s)  487,331,205,120 bytes free

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>csc /t:library /out:Farm.dll /keyfile:KulpotKey.key Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder

28/09/2023  12:13 pm    <DIR>          .
28/09/2023  12:13 pm    <DIR>          ..
28/09/2023  11:58 am               189 App.config
28/09/2023  11:58 am    <DIR>          bin
28/09/2023  11:58 am             2,384 DotNet GAC Folder.csproj
28/09/2023  12:13 pm             4,096 Farm.dll
28/09/2023  11:02 am               596 KulpotKey.key
28/09/2023  11:58 am    <DIR>          obj
28/09/2023  12:12 pm            18,273 Program.cs
28/09/2023  11:58 am    <DIR>          Properties
28/09/2023  12:10 pm               596 YourKey.snk
               6 File(s)         26,134 bytes
               5 Dir(s)  487,330,828,288 bytes free

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>gacutil -i Farm.dll
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Assembly successfully added to the cache

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>erase Farm.dll

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder

28/09/2023  12:14 pm    <DIR>          .
28/09/2023  12:14 pm    <DIR>          ..
28/09/2023  11:58 am               189 App.config
28/09/2023  11:58 am    <DIR>          bin
28/09/2023  11:58 am             2,384 DotNet GAC Folder.csproj
28/09/2023  11:02 am               596 KulpotKey.key
28/09/2023  11:58 am    <DIR>          obj
28/09/2023  12:14 pm            19,666 Program.cs
28/09/2023  11:58 am    <DIR>          Properties
28/09/2023  12:10 pm               596 YourKey.snk
               5 File(s)         23,431 bytes
               5 Dir(s)  487,330,050,048 bytes free

-------------YourKey.snk gacutil -i Farm.dll ---------------------
C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>csc /t:library /out:Farm.dll /keyfile:YourKey.snk Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>gacutil -i Farm.dll
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Assembly successfully added to the cache

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>sn -p YourKey.snk YourPublicKey.whatever

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Public key written to YourPublicKey.whatever

C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>sn -tp YourPublicKey.whatever

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Public key (hash algorithm: sha1):
0024000004800000940000000602000000240000525341310004000001000100c5d41d9269420b
31182d87f8356baebd4e7d3feaf2771ff13b861b6d6a8dd838546ad167f736f464a04250db1d71
e65dd423093f4b34ffc62678753081aae9f21bc4b1723e56f434d3e1ab10a5540f7e491166f8ac
80dd059281d23e4c55dccd5c8d5dba335a4209b92abe47e0037e4e6dd4d6569c5c09fe905e4d04
cc50fbb5

Public key token is 2f4bcac2715a74ca

------------------Uninstall -----gacutil -u Farm-----------------
C:\Users\sunny\source\repos\DotNet GAC Folder\DotNet GAC Folder>gacutil -u Farm
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.


Assembly: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=2f4bcac2715a74ca, processorArchitecture=MSIL
Uninstalled: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=2f4bcac2715a74ca, processorArchitecture=MSIL

Assembly: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=439d39c99d560b47, processorArchitecture=MSIL
Uninstalled: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=439d39c99d560b47, processorArchitecture=MSIL
Number of assemblies uninstalled = 2
Number of failures = 0
------------------------------------------------------------------
----------------DotNet Assembly Probing-----------------------Start
C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>sn -k KulpotKey.snk

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to KulpotKey.snk

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:39 am    <DIR>          .
29/09/2023  11:39 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:35 am            23,324 Program.cs
29/09/2023  11:33 am    <DIR>          Properties
               4 File(s)         26,505 bytes
               5 Dir(s)  487,660,802,048 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probingcsc /r:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:42 am    <DIR>          .
29/09/2023  11:42 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  05:17 am             3,584 Farm.dll
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:39 am            24,394 Program.cs
29/09/2023  11:42 am             4,096 Program.exe
29/09/2023  11:33 am    <DIR>          Properties
               6 File(s)         35,255 bytes
               5 Dir(s)  487,659,614,208 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>Program.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>ren Farm.dll Farm.exe

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:45 am    <DIR>          .
29/09/2023  11:45 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  05:17 am             3,584 Farm.exe <-------rename from Farm.dll
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:43 am            25,656 Program.cs
29/09/2023  11:42 am             4,096 Program.exe
29/09/2023  11:33 am    <DIR>          Properties
               6 File(s)         36,517 bytes
               5 Dir(s)  487,662,612,480 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>ildasm /out:moo.txt Program.exe

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>moo.txt
----------------------NOTEPAD: moo.txt------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern Farm
{
  .ver 1:0:0:0
}
.assembly Program
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Program.exe
// MVID: {36F5A6DA-985D-4320-929B-351CE9094CFB}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06780000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  call       void [Farm]Cow::Moo()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class MainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


----------------------NOTEPAD: moo.txt------------------------END

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>Program.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>erase *.exe

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:48 am    <DIR>          .
29/09/2023  11:48 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:46 am             1,128 moo.res
29/09/2023  11:46 am             4,880 moo.txt
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:48 am            32,022 Program.cs
29/09/2023  11:33 am    <DIR>          Properties
               6 File(s)         41,211 bytes
               5 Dir(s)  487,659,433,984 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>erase moo.*
-----------CREATED---------------------
[assembly: AssemblyVersion("1.0.0.0")]

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Kulpots moooooooooooo version 1");
    }
}

//class MainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//    }
//}

----------------------------------------------

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>csc /t:library /out:Farm.dll /keyfile:KulpotKey.snk Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

-----------CREATED---------------------
//[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Kulpots moooooooooooo version 1");
//    }
//}

class MainClass
{
    static void Main()
    {
        Cow.Moo();
    }
}

----------------------------------------------
C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>csc /r:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:53 am    <DIR>          .
29/09/2023  11:53 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  11:50 am             4,096 Farm.dll
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:53 am            34,323 Program.cs
29/09/2023  11:53 am             4,096 Program.exe
29/09/2023  11:33 am    <DIR>          Properties
               6 File(s)         45,696 bytes
               5 Dir(s)  487,654,670,336 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>Program.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>ren Farm.dll Farm.exe

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>Program.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>md Farm

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>move Farm.dll Farm
The system cannot find the file specified.

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:55 am    <DIR>          .
29/09/2023  11:55 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  11:55 am    <DIR>          Farm
29/09/2023  11:50 am             4,096 Farm.exe
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:54 am            35,574 Program.cs
29/09/2023  11:53 am             4,096 Program.exe
29/09/2023  11:33 am    <DIR>          Properties
               6 File(s)         46,947 bytes
               6 Dir(s)  487,654,068,224 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>move Farm.exe Farm
        1 file(s) moved.

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:56 am    <DIR>          .
29/09/2023  11:56 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  11:56 am    <DIR>          Farm
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:56 am            36,746 Program.cs
29/09/2023  11:53 am             4,096 Program.exe
29/09/2023  11:33 am    <DIR>          Properties
               5 File(s)         44,023 bytes
               6 Dir(s)  487,653,834,752 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>Program.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>ren Farm moo

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  11:57 am    <DIR>          .
29/09/2023  11:57 am    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:56 am    <DIR>          moo
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  11:57 am            37,768 Program.cs
29/09/2023  11:53 am             4,096 Program.exe
29/09/2023  11:33 am    <DIR>          Properties
               5 File(s)         45,045 bytes
               6 Dir(s)  487,653,326,848 bytes free

----------PROBE RUNTIME ERROR cause of name change from Farm to moo------------
C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>Program.exe

Unhandled Exception: System.IO.FileNotFoundException: Could not load file or assembly 'Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f913a8f0098e4d41' or one of its dependencies. The system cannot find the file specified.
   at MainClass.Main()
----------PROBE RUNTIME ERROR cause of name change from Farm to moo------------END

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>ren moo Farm

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>Program.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Probing\DotNet Assembly Probing

29/09/2023  12:00 pm    <DIR>          .
29/09/2023  12:00 pm    <DIR>          ..
29/09/2023  11:29 am               189 App.config
29/09/2023  11:29 am    <DIR>          bin
29/09/2023  11:30 am             2,396 DotNet Assembly Probing.csproj
29/09/2023  11:56 am    <DIR>          Farm
29/09/2023  11:39 am               596 KulpotKey.snk
29/09/2023  11:29 am    <DIR>          obj
29/09/2023  12:00 pm            39,607 Program.cs
29/09/2023  11:53 am             4,096 Program.exe
29/09/2023  11:33 am    <DIR>          Properties
               5 File(s)         46,884 bytes
               6 Dir(s)  487,658,455,040 bytes free

---------------------------------------------------------------------------------------
----------------------------DotNET Assembly Probing and privatePath---------------------START

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>sn -k KulpotKey.snk

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to KulpotKey.snk

-----------CREATED-------------------
[assembly: AssemblyVersion("1.0.0.0")]

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Moooooooooooooooooo version 1");
    }
}
----------------------------------------

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>csc /t:library /out:Farm.dll /keyfile:KulpotKey.snk Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath

30/09/2023  06:56 am    <DIR>          .
30/09/2023  06:56 am    <DIR>          ..
30/09/2023  06:45 am               189 App.config
30/09/2023  06:45 am    <DIR>          bin
30/09/2023  06:46 am             2,428 DotNET Assembly Probing and privatePath.csproj
30/09/2023  06:56 am             4,096 Farm.dll
30/09/2023  06:53 am               596 KulpotKey.snk
30/09/2023  06:45 am    <DIR>          obj
30/09/2023  06:54 am            40,249 Program.cs
30/09/2023  06:49 am    <DIR>          Properties
               5 File(s)         47,558 bytes
               5 Dir(s)  486,988,980,224 bytes free

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>csc /r:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath

30/09/2023  06:59 am    <DIR>          .
30/09/2023  06:59 am    <DIR>          ..
30/09/2023  06:45 am               189 App.config
30/09/2023  06:45 am    <DIR>          bin
30/09/2023  06:46 am             2,428 DotNET Assembly Probing and privatePath.csproj
30/09/2023  06:56 am             4,096 Farm.dll
30/09/2023  06:53 am               596 KulpotKey.snk
30/09/2023  06:45 am    <DIR>          obj
30/09/2023  06:59 am            42,304 Program.cs
30/09/2023  06:58 am             4,096 Program.exe
30/09/2023  06:49 am    <DIR>          Properties
               6 File(s)         53,709 bytes
               5 Dir(s)  486,986,952,704 bytes free

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>Program.exe
Moooooooooooooooooo version 1

-------------Make and Move Files to Directory--------
C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>md MeAssemblies

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>move Farm.dll MeAssemblies
        1 file(s) moved.

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath

30/09/2023  07:05 am    <DIR>          .
30/09/2023  07:05 am    <DIR>          ..
30/09/2023  06:45 am               189 App.config
30/09/2023  06:45 am    <DIR>          bin
30/09/2023  06:46 am             2,428 DotNET Assembly Probing and privatePath.csproj
30/09/2023  06:53 am               596 KulpotKey.snk
30/09/2023  07:05 am    <DIR>          MeAssemblies
30/09/2023  06:45 am    <DIR>          obj
30/09/2023  07:05 am            43,440 Program.cs
30/09/2023  06:58 am             4,096 Program.exe
30/09/2023  06:49 am    <DIR>          Properties
               5 File(s)         50,749 bytes
               6 Dir(s)  486,997,000,192 bytes free

C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath>Program.exe
-----ERROR: Farm is inside MeAssemblies <DIR>--------------------
Unhandled Exception: System.IO.FileNotFoundException: Could not load file or assembly 'Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=d9ae9abd90506f0e' or one of its dependencies. The system cannot find the file specified.
   at MainClass.Main()

----------Create-CONFIG FILES----------------------
create -> txt file(name: Program.exe.config) in -> path:C:\Users\sunny\source\repos\DotNET Assembly Probing and privatePath\DotNET Assembly Probing and privatePath -> drag then drop file to VS ->

<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<runtime>
		<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
			<probing privatePath="MeAssemblies" />
		</assemblyBinding>
	</runtime>
</configuration>

-------------------------------------------------








 * 
 */


[assembly: AssemblyVersion("1.0.0.0")]

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Moooooooooooooooooo version 1");
    }
}

//class MainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//    }
//}

