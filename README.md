# Code blending

하루를 다양한 언어와 간단한 알고리즘으로 시작해 봅니다.

## Languages

|Used|Unused|
|---|---|
|C||
|Java||
|Python(^3.0.0)||
|Javascript||
|GO||
|Ruby||
|PHP||
|Scala||
|Haskell||
|C++||
|Shell Script(bash)||
|C#||
|Lisp (Common Lisp)||
|Lua||
||MySQL (Function)|
||Objective-C|
||Swift|
||Perl|
||Pascal|
||R|
||Scratch|
||Smalltalk|

## How to "Hello, World!" on OSX

### C

```c
// hello-world.c
#include <stdio.h>

int main() {
    printf("Hello, world!\n");
}
```
```bash
gcc hello-world.c # Compile source code.
./a.out           # "Hello, World!"
```

### Java

```bash
brew cask install java
```
```java
// hello-world.java
class HelloWorld {
    public static void main(String[] args) {
        System.out.println("Hello, World!");
    }
}
```
```bash
javac hello-world.java # Compile source code.
java HelloWorld        # "Hello, World!"
```

### Python (3.x)

```bash
brew install python3
```
```python
# hello-world.py
print("Hello, World!")
```
```bash
python3 hello-world.py
```

### Javascript

```bash
brew install node
```
```javascript
// hello-world.js
console.log('Hello, World!');
```
```bash
node hello-world.js
```

### GO

```bash
brew install go
```
```go
// hello-world.go
package main

import "fmt"

func main() {
    fmt.Println("hello world")
}
```
```bash
go run hello-world.go   # case 1 - Run immediately

go build hello-world.go # case 2 - Build first
./hello-world           #        - and run
```

### C++
```cpp
// hello-world.cpp
#include <iostream>

int main() {
    std::cout << "Hello, World!" << std::endl;
}
```
```bash
g++ hello-world.cpp # Compile source code.
./a.out             # "Hello, World!"
```

### Shell Script(bash)

```bash
#!/bin/bash

# hello-world.sh
echo "Hello, World!"
```
```bash
source hello-world.sh   # case 1 - "Hello, World!"

chmod +x hello-world.sh # case 2 - Add Execute permission to file
./hello-world.sh        #        - "Hello, World!"
```

### C# #

```bash
brew cask install dotnet
dotnet new     # Init and generate "hello, world!" c# seed project
dotnet restore # Restore dependencies specified in the 'project.json'
dotnet run     # "Hello, World!"
```

### Common Lisp

```bash
brew install clisp
```
```Lisp
; hello-world.lisp
(print "Hello, World!")
```
```bash
clisp hello-world.lisp
```

### Lua

```bash
brew install lua
```
```Lua
-- hello-world.lua
print "Hello, World!" -- case 1
print("Hello, World!") -- case 2
```
```bash
lua hello-world.lua
```
