# _C#-Word Counter_

#### _Single Webpage for Epicodus, 11.16.2018_

#### By _**Glen Sale**_

## Description

_Create a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)_


###_Bassic Structure of Directory for Program and Testing_

__Word-Counter.Solution
├── WordCounter
│   ├── WordCounter.csproj
│   └── obj
│       ├── WordCounter.csproj.nuget.cache
│       ├── WordCounter.csproj.nuget.g.props
│       ├── WordCounter.csproj.nuget.g.targets
│       └── project.assets.json
└── WordCounter.Tests
    ├── WordCounter.Tests.csproj
    └── obj
        ├── WordCounter.Tests.csproj.nuget.cache
        ├── WordCounter.Tests.csproj.nuget.g.props
        ├── WordCounter.Tests.csproj.nuget.g.targets
        └── project.assets.json__

*_For More click the link :_ **https://www.learnhowtoprogram.com/c/c-basics-and-testing/mstest-configuration-and-setup_        
### Specs
| Spec | Search | Text | Result |
| :-------------     | :------------- | :------------- | :------------- |
| **Program matches lowercase or uppercase Letters** | Search: "basketball" | Text: "Basketball is my favorite sport" |  Result: No match found |
| **Program Counts The Word that matches in the sentence** | Search: "test" | Text: "This test is a sample testing" |  Result: "matches 1" |
| **Program Gathers Sentence** | Search : "This sample is a sample" | Text: "This sample is a sample"|  Result: matches 1 |
| **Program Gathers List of Words** | Search: "sample" | Text: "sample, sample, sample"|  Result: "sample matches 3" |


##Setup/Installation Requirements
*Clone this repository https://github.com/glenpogz36/C-WordCounter--.git
*Install Mono and .NET Framework
*Open the folder and run Program.exe in Mono
*Follow command prompts in Terminal

## Technologies Used

*_C#_
*_.NET_
*_mono_
*Atom_
*_GitHub_


### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Glen Sale_**
