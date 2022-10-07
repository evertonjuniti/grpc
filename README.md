# PoC - ISO8583

This PoC (Proof of Concept) project aims an implementation using a ISO 8583 library to reduce the payload in any request-response integration between applications.

I'll try to implement this within some programming languages (like C#, Kotlin, Swift and Node.js) and some different protocols (like REST and gRPC).

EBCDIC RFC: [https://www.ietf.org/rfc/rfc183.html](https://www.ietf.org/rfc/rfc183.html)

Oscar Sanderson ISO-8583: [https://oscarsanderson.com/iso-8583/](https://oscarsanderson.com/iso-8583/)

How to install C and C++ compiler on Windows: [https://www.freecodecamp.org/news/how-to-install-c-and-cpp-compiler-on-windows/](https://www.freecodecamp.org/news/how-to-install-c-and-cpp-compiler-on-windows/)

MSYS2: [https://www.msys2.org/](https://www.msys2.org/)

GCC: [https://gcc.gnu.org/install/](https://gcc.gnu.org/install/)

To compile an .c file and output to and .o file, use the following command:

'cc -c [.c filename]' -> -c will output the result in an .o file

To make an .dll file, type the following command:

'gcc -shared -o iso8583.dll dl_iso8583.o dl_iso8583_common.o dl_iso8583_defs_1987.o dl_iso8583_defs_1993.o dl_iso8583_fields.o dl_mem.o dl_output.o dl_str.o dl_time.o dl_timer.o'

https://blog.quickbird.uk/calling-c-from-net-core-759563bab75d

https://learn.microsoft.com/en-us/dotnet/framework/interop/marshalling-data-with-platform-invoke

https://learn.microsoft.com/en-us/dotnet/framework/interop/marshalling-classes-structures-and-unions

https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types

https://codereview.stackexchange.com/questions/190907/custom-enumeration-classes

https://stackoverflow.com/questions/6637679/reflection-get-attribute-name-and-value-on-property