# ISO-8583 C library from Oscar Sanderson

In this README I'll show you some instructions about how to use this library and how to compile it

The first thing you have to know is that there are some .c and .h files in dl_c_common_v0_0_2 and dl_c_iso8583_v0_0_3 folders, you need only the files in those 2 folders do compile the entire library.

The benchmark.c and demo.c files show the usage of all the main functions of this C library.

Okay, now that you have an introduction about this, let me say some useful things:

## If you want to use the templated fields of 1987 or 1993 representation, or if you need to create your own!

Inside the dl_c_iso8583_v0_0_3 folder are some core files that represents all the fields you have to know to use the 1987 or 1993 definition.

You don't have to use any of these if they don't satisfy your needs, but if this is the case you have do copy any of dl_iso8583_defs_1987.c and dl_iso8583_defs_1987.h or dl_iso8583_defs_1993.c and dl_iso8583_defs_1993.h and create your own definition (eg: dl_iso8583_defs_myowndefinition.c and dl_iso8583_defs_myowndefinition.h).

As you can see in demo.c file, one of the very first things you have to do is call this command:

`DL_ISO8583_DEFS_1993_GetHandler(&isoHandler);`

In this case you set the isoHandler variable with the field template definition of 1993, if you want to use some other (one that you create) just modify this command when you call it in your application. Eg:

`DL_ISO8583_DEFS_MyOwnDefinition_GetHandler(&isoHandler);`

## If you want to compile this library (modifying it or not)

Okay, so you decided to compile this thing, there are some few steps you can follow to acomplish this (if you're like me with little or no knowledge with C language):

You can follow the steps in this particular site: [https://www.freecodecamp.org/news/how-to-install-c-and-cpp-compiler-on-windows/](https://www.freecodecamp.org/news/how-to-install-c-and-cpp-compiler-on-windows/)

But in case the site is down, I'll show you how to do all the steps (they're the same in the above site, so you can choose where to read and follow the steps. The real difference is in the steps bellow all the Print - Installation - screens are from my personal virtual machine):

`Remember: I literally copied all of the instructions of the above website, I did this in the case the site is down`

At the end of this README I'll show you how to compile the library after you install and configure the compiler

### Step 1 - Install MSYS2

`Maybe some printed screens will be in another language than English`

Firstly we need to download an executable file from MSYS2. Go to the official website of MSYS2: [https://www.msys2.org/](https://www.msys2.org/). The website looks like below as of today.

![Print - Installation - 1](/../main/images/c_cpp_compiler_installation_print1.png)

Scroll down a little bit until you find the download button for the executable file.

![Print - Installation - 2](/../main/images/c_cpp_compiler_installation_print2.png)

Simply click on the installer button to start the download. Finish downloading the executable file. It should not take much time depending on your internet speed.

After downloading the file, we will get this executable file.

![Print - Installation - 3](/../main/images/c_cpp_compiler_installation_print3.png)

> If the above link is broken, no worries, in this repository I've created a folder called `Installer`, I've compressed the executable file in a set of `.rar` files (because Github have a size limit for file upload), you just need `WinRAR` to decompress the executable file.

Double click on the executable file. Then click Next.

![Print - Installation - 4](/../main/images/c_cpp_compiler_installation_print4.png)

Keep the name as it is, and click Next.

![Print - Installation - 5](/../main/images/c_cpp_compiler_installation_print5.png)

Keep all this as it is, and click Next.

![Print - Installation - 6](/../main/images/c_cpp_compiler_installation_print6.png)

Give it some time to finish the installation process.

![Print - Installation - 7](/../main/images/c_cpp_compiler_installation_print7.png)

If you keep the checkmark, then the MSYS2 terminal will open once you click Finish.

![Print - Installation - 8](/../main/images/c_cpp_compiler_installation_print8.png)

I prefer to do it this way, but if you want to do the remaining tasks later, then you need to open the terminal by yourself from the start menu.

In that case, you have to click the start button > Search for MSYS2 and click on the terminal like in the following picture:

![Print - Installation - 9](/../main/images/c_cpp_compiler_installation_print9.png)

Let me assume that we have opened the MSYS2 MSYS terminal successfully.

Apply the command `pacman -Syu` to update the package database and the base packages.

![Print - Installation - 10](/../main/images/c_cpp_compiler_installation_print10.png)

Type `Y` and press the enter key if you get this type of installation prompt.

![Print - Installation - 11](/../main/images/c_cpp_compiler_installation_print11.png)

![Print - Installation - 12](/../main/images/c_cpp_compiler_installation_print12.png)

![Print - Installation - 13](/../main/images/c_cpp_compiler_installation_print13.png)

Type `Y` and press the enter key.

![Print - Installation - 14](/../main/images/c_cpp_compiler_installation_print14.png)

![Print - Installation - 15](/../main/images/c_cpp_compiler_installation_print15.png)

The terminal will be closed. We have to open the terminal manually and update the rest of the packages.

Click the start button.

![Print - Installation - 16](/../main/images/c_cpp_compiler_installation_print16.png)

Search the folder named MSYS2 64bit. Click on the folder to expand and get the terminal. Open the terminal by clicking MSYS2 MSYS.

![Print - Installation - 17](/../main/images/c_cpp_compiler_installation_print17.png)

Update the rest of the packages by applying the command, `pacman -Su`. You might need to apply the command `pacman -Sy` if the terminal tells you to do that.

![Print - Installation - 18](/../main/images/c_cpp_compiler_installation_print18.png)

If you get any installation prompt, then you need to type `Y` or `y` and press the enter key.

![Print - Installation - 19](/../main/images/c_cpp_compiler_installation_print19.png)

![Print - Installation - 20](/../main/images/c_cpp_compiler_installation_print20.png)

Wait a little to finish the installation.

![Print - Installation - 21](/../main/images/c_cpp_compiler_installation_print21.png)

![Print - Installation - 22](/../main/images/c_cpp_compiler_installation_print22.png)

Close the window after finishing the installation.

### Step 2 - Install the GCC and G++ Compilers

Click the start button. Find the MSYS2 64bit folder. Click on that folder to expand it.

![Print - Installation - 23](/../main/images/c_cpp_compiler_installation_print23.png)

> If you are using a 64 bit operating system like I am, then we need to use the MSYS2 MinGW x64 terminal. Click on the terminal to open that.

![Print - Installation - 24](/../main/images/c_cpp_compiler_installation_print24.png)

> But, if you are using a 32 bit operating system, then you have to use the MSYS2 MinGW x86 terminal. Then, you need to open that terminal.

![Print - Installation - 25](/../main/images/c_cpp_compiler_installation_print25.png)

> As I am using a 64 bit operating system, I have opened the terminal for 64 bit. Apply the command `pacman -S mingw-w64-x86_64-gcc` to install the compilers.

> If you are using a 32 bit operating system, then you have to apply the command `pacman -S mingw-w64-i686-gcc` in your 32 bit terminal.

![Print - Installation - 26](/../main/images/c_cpp_compiler_installation_print26.png)

Wait for a little while.

![Print - Installation - 27](/../main/images/c_cpp_compiler_installation_print27.png)

Type `Y` or `y` and press the enter key if you get the installation prompts.

![Print - Installation - 28](/../main/images/c_cpp_compiler_installation_print28.png)

Give it some time to finish the installation process.

![Print - Installation - 29](/../main/images/c_cpp_compiler_installation_print29.png)

![Print - Installation - 30](/../main/images/c_cpp_compiler_installation_print30.png)

You've now finished installing the compilers.

### Step 3 - How to Install the Debugger

> If you are using a 64 bit operating system like I am, then you have to apply the command `pacman -S mingw-w64-x86_64-gdb`.

> If you are using a 32 bit operating system, then you have to apply the command `pacman -S mingw-w64-i686-gdb` in your 32 bit terminal.

![Print - Installation - 31](/../main/images/c_cpp_compiler_installation_print31.png)

If you get any installation prompt, then simply type `Y` or `y` and press the enter key.

![Print - Installation - 32](/../main/images/c_cpp_compiler_installation_print32.png)

![Print - Installation - 33](/../main/images/c_cpp_compiler_installation_print33.png)

Give it some time to finish the installation.

![Print - Installation - 34](/../main/images/c_cpp_compiler_installation_print34.png)

![Print - Installation - 35](/../main/images/c_cpp_compiler_installation_print35.png)

You can close the terminal.

### Step 4 - How to Add the Directory to the Path of the Environment Variables

Open the file explorer.

![Print - Installation - 36](/../main/images/c_cpp_compiler_installation_print36.png)

I am assuming that you have installed the MSYS into the default directory like I have. If you used custom directories, then you need to go to the directory where you installed it.

![Print - Installation - 37](/../main/images/c_cpp_compiler_installation_print37.png)

> If you are using a 64 bit operating system like I am, then go to the `mingw64` folder.

> If you are using a 32 bit operating system, then go to the `mingw32` folder.

![Print - Installation - 38](/../main/images/c_cpp_compiler_installation_print38.png)

We have to go to the binary folder now. Go to the `bin` folder.

![Print - Installation - 39](/../main/images/c_cpp_compiler_installation_print39.png)

If you are using a 32 bit operating system, then you have to go into your `mingw32` folder > `bin` folder.

Copy the directory.

![Print - Installation - 40](/../main/images/c_cpp_compiler_installation_print40.png)

> If you are using a 32 bit operating system, and you also installed the MSYS2 in the default directory, then your directory should be like the following:

`C:\msys64\mingw32\bin`

Open the `Advanced System Settings`. You can do that in many ways. A simple way is to simply click the start button and search for it like the below screenshot.

![Print - Installation - 41](/../main/images/c_cpp_compiler_installation_print41.png)

Click `Environment Variables` from the Advanced tab.

![Print - Installation - 42](/../main/images/c_cpp_compiler_installation_print42.png)

Click on `Path` and select that. Then click `Edit`.

![Print - Installation - 43](/../main/images/c_cpp_compiler_installation_print43.png)

A window will appear as below:

![Print - Installation - 44](/../main/images/c_cpp_compiler_installation_print44.png)

Click `New`.

![Print - Installation - 45](/../main/images/c_cpp_compiler_installation_print45.png)

A blank box will appear.

![Print - Installation - 46](/../main/images/c_cpp_compiler_installation_print46.png)

Paste the directory here.

![Print - Installation - 47](/../main/images/c_cpp_compiler_installation_print47.png)

![Print - Installation - 48](/../main/images/c_cpp_compiler_installation_print48.png)

Click `OK`.

![Print - Installation - 49](/../main/images/c_cpp_compiler_installation_print49.png)

Click `OK`.

![Print - Installation - 50](/../main/images/c_cpp_compiler_installation_print50.png)

Click `OK`.

![Print - Installation - 51](/../main/images/c_cpp_compiler_installation_print51.png)

### Step 5 - Check the Install

Now it is time to check whether we have successfully installed all of the above or not.

Open the terminal / PowerShell / CMD and apply the commands serially:

For checking the `GCC` version:

`gcc --version`

![Print - Installation - 52](/../main/images/c_cpp_compiler_installation_print52.png)

For checking the `G++` version:

`g++ --version`

![Print - Installation - 53](/../main/images/c_cpp_compiler_installation_print53.png)

For checking the `GDB` version:

`gdb --version`

![Print - Installation - 54](/../main/images/c_cpp_compiler_installation_print54.png)

### Step 6 - Finally we will try to compile this!

Ok, I'm assuming you already have Git installed in your computer and you already cloned this repository, so I'll go from this on:

Go to this folder:

`poc-iso8583\ISO8583_Library\dl_c_iso8583_v0_0_4_160708_allfiles`

We have to compile `.c` files to create `.o` (object) files, because some of the `.c` files depends on some `.h` (header) files, it's easier if we catch all of the files from these folders and `copy paste` them all together in another folder just for compilation, we can delete this new folder after the compilation succeeds.

Well, I've created here in my Virtual Machine a new folder called `for_compilation`, then I've copied all of the files from `dl_c_common_v0_0_2` and `dl_c_iso8583_v0_0_3` folders to this new folder:

![Print - Compilation - 1](/../main/images/c_cpp_compiler_compilation_print1.png)

![Print - Compilation - 2](/../main/images/c_cpp_compiler_compilation_print2.png)

![Print - Compilation - 3](/../main/images/c_cpp_compiler_compilation_print3.png)

![Print - Compilation - 4](/../main/images/c_cpp_compiler_compilation_print4.png)

![Print - Compilation - 5](/../main/images/c_cpp_compiler_compilation_print5.png)

Open CMD from this `for_compilation` folder, you can do this by clicking in the address bar on Windows Explorer, typing `cmd` and then pressing the `ENTER` key on your keyboard:

![Print - Compilation - 6](/../main/images/c_cpp_compiler_compilation_print6.png)

![Print - Compilation - 7](/../main/images/c_cpp_compiler_compilation_print7.png)

![Print - Compilation - 8](/../main/images/c_cpp_compiler_compilation_print8.png)

Ok, now here comes the hard working phase: we have to compile each `.c` file to create an `.o` file, the `.o` files are the objects files needed to create the final `.dll` file.

We need to run this command for each `.c` file residing the `for_compilation` folder.

The command:

`cc -c [.c filename]`

All of the commands:

`cc -c dl_mem.c`
`cc -c dl_output.c`
`cc -c dl_str.c`
`cc -c dl_time.c`
`cc -c dl_timer.c`
`cc -c dl_iso8583.c`
`cc -c dl_iso8583_common.c`
`cc -c dl_iso8583_defs_1987.c`
`cc -c dl_iso8583_defs_1993.c`
`cc -c dl_iso8583_fields.c`

Important: if you have created any new `.c` file, you have to compile it too!

![Print - Compilation - 9](/../main/images/c_cpp_compiler_compilation_print9.png)

![Print - Compilation - 10](/../main/images/c_cpp_compiler_compilation_print10.png)

![Print - Compilation - 11](/../main/images/c_cpp_compiler_compilation_print11.png)

If you have done all of the commands correctly, I'll see the `.o` files for each `.c` file you've compiled:

![Print - Compilation - 12](/../main/images/c_cpp_compiler_compilation_print12.png)

![Print - Compilation - 13](/../main/images/c_cpp_compiler_compilation_print13.png)

![Print - Compilation - 14](/../main/images/c_cpp_compiler_compilation_print14.png)

Now the final part is to run the following command to create an `.dll` file:

`gcc -shared -o iso8583.dll dl_iso8583.o dl_iso8583_common.o dl_iso8583_defs_1987.o dl_iso8583_defs_1993.o dl_iso8583_fields.o dl_mem.o dl_output.o dl_str.o dl_time.o dl_timer.o`

![Print - Compilation - 15](/../main/images/c_cpp_compiler_compilation_print15.png)

![Print - Compilation - 16](/../main/images/c_cpp_compiler_compilation_print16.png)

We can see our newly created `iso8583.dll` file:

![Print - Compilation - 17](/../main/images/c_cpp_compiler_compilation_print17.png)

### Congratulations!

We made it! We compiled this ISO-8583 library and can use it with other programming languages!

> Because I'm running all of this on a 64-bit OS, and knowing that my configuration for the compiler also follows this OS architecture, the `.dll` generated file is also for 64-bit applications.

> If you need also the 32-bit `.dll` file you'll need to use `C:\msys64\mingw32\bin` preceding all of the above commands to create the `.o` files and to create the `.dll` file.