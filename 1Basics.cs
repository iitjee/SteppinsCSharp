


C# is strongly typed. (i.e once the type is assigned, it's fixed)
Types in .NET are represented as classes or structures
Both have members: fields and methods

Structures are value types:
int v1 = 5;
int v2 = v1; //v2 is a copy of v1

Classes are reference types
Object o1 = new Object();
Object o2 = o2; //o2 references o1


/* Common Structures */
Numerical and logical built-in types are structures in .NET and winRT
String is a class, not a structure. Yet, in actual behaviour it's more like structure
eg: bool, int(32-bit), double(32-bit), decimal(128-bit)

C#Type:   .NET Type:
bool      Boolean
char      Char
byte      Byte
sbyte     SByte
short     Int16
ushort    UInt16
int       Int32
uint      UInt32
long      Long
ulong     ULong

Note: 'C# Type are called aliases'
      All .NET types are members of System: i.e System.Boolean or System.Char
      
C#Type:   .NET Type:
float     Single
double    Double
decimal   Decimal
string    String

String:
