---
title: Creating a .CS file from an .XSD file
url: https://developer.tekla.com/documentation/cs-file-xsd-file
slug: cs-file-xsd-file
kind: Guide
section: Getting started
section_folder: Getting_Started
breadcrumb:
- Tekla PowerFab
- Creating a .CS file from an .XSD file
updated: 23 Oct 2025
---

# Creating a .CS file from an .XSD file

If you have been provided an .xsd file without a matching .cs file, it’s possible to quickly generate one for your use.

1. Open Developer Studio Command Prompt  
   This can be done by either opening Visual Studio Tools->Command Line->Developer Studio Command Prompt, or by opening it directly from the start menu.
2. Navigate to the directory where the .xsd file is located. (Navigate using “cd”)
3. Run this command: “xsd /classes [name-of-xsd-file]”.    
   After that, the .cs file will exist in the same directory.

Here’s what is looks like on my computer:

Screenshot of Command Prompt showing executing of command: xsd /classes
