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
||MySQL|
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

### Python(^3.0.0)

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
