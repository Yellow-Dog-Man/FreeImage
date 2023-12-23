# What is FreeImage ?

FreeImage is an Open Source library project for developers who would like to support popular graphics image formats like PNG, BMP, JPEG, TIFF and others as needed by today's multimedia applications.
FreeImage is easy to use, fast, multithreading safe, and cross-platform (works with Windows, Linux and Mac OS X).

Thanks to it's ANSI C interface, FreeImage is usable in many languages including C, C++, VB, C#, Delphi, Java and also in common scripting languages such as Perl, Python, PHP, TCL, Lua or Ruby.

The library comes in two versions: a binary DLL distribution that can be linked against any WIN32/WIN64 C/C++ compiler and a source distribution.
Workspace files for Microsoft Visual Studio provided, as well as makefiles for Linux, Mac OS X and other systems.

# Yellow Dog Man Studios Changes
This is a fork of the original freeimage 3.18.0 source code available at: https://freeimage.sourceforge.io/.

Our changes are roughly detailed below, the full changes can be read by reading the linked commits, other minor changes might be missing from this list, please feel free to PR changes to the list:
* [Updated WebP library to the latest](https://github.com/Yellow-Dog-Man/FreeImage/pull/1) to fix security issues
* [Added ability to use WEBP_EXACT to preserve information in the alpha channel](https://github.com/Yellow-Dog-Man/FreeImage/commit/a90b0347f68ae08bb3e6f959ac9b36a066137c0d)
* [Added Android NDK build files and some changes to it builds properly](https://github.com/Yellow-Dog-Man/FreeImage/commit/a90b0347f68ae08bb3e6f959ac9b36a066137c0d)
* [Updated .NET wrapper with new functions + AOT compatibility](https://github.com/Yellow-Dog-Man/FreeImage/commit/6b93b6be786c3bfe1915c20e63219fd17e3d8744)
