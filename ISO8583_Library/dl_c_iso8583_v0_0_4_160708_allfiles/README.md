# ISO-8583 C library from Oscar Sanderson

In this README I'll show you some instructions about how to use this library and how to compile it

The first thing you have to know is that there are some .c and .h files in dl_c_common_v0_0_2 and dl_c_iso8583_v0_0_3 folders, you need only the files in those 2 folders do compile the entire library.

The benchmark.c and demo.c files show the usage of all the main functions of this C library.

Okay, now that you have an introduction about this, let me say some useful things:

## If you want to use the templated fields of 1987 or 1993 representation, or if you need to create your own!

Inside the dl_c_iso8583_v0_0_3 folder are some core files that represents all the fields you have to know to use the 1987 or 1993 definition.

You don't have to use any of these if they don't satisfy your needs, but if is this the case you have do copy any of dl_iso8583_defs_1987.c and dl_iso8583_defs_1987.h or dl_iso8583_defs_1993.c and dl_iso8583_defs_1993.h and create your own definition (eg: dl_iso8583_defs_myowndefinition.c and dl_iso8583_defs_myowndefinition.h).

As you can see in demo.c file, one of the very first things you have to do is call this command:

`DL_ISO8583_DEFS_1993_GetHandler(&isoHandler);`

In this case you set the isoHandler variable with the field template definition of 1993, if you want to use some other (one that you create) just modify this command when you call it in your application. Eg:

`DL_ISO8583_DEFS_MyOwnDefinition_GetHandler(&isoHandler);`

## If you want to compile this library (modifying it or not)

Okay, so you decided to compile this thing, there are some few steps you can follow to acomplish this (if you're like me with little or no knowledge with C language):

You can follow the steps in this particular site: [https://www.freecodecamp.org/news/how-to-install-c-and-cpp-compiler-on-windows/](https://www.freecodecamp.org/news/how-to-install-c-and-cpp-compiler-on-windows/)

But in case the site is down, I'll show you how to do all the steps (they're the same in the above site, so you can choose where to read and follow the steps. The real difference is in the steps bellow all the print screens are from my personal virtual machine):

### Step 1 - Download MSYS

Firstly we need to download an executable file from MSYS2. Go to the official website of MSYS2: [https://www.msys2.org/](https://www.msys2.org/). The website looks like below as of today.

![Print 1](/../../../main/images/c_cpp_compiler_installation_print1.png)