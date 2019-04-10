# MediaManager [![Build Status](https://travis-ci.com/NinjaMiellies/MediaManager.svg?branch=master)](https://travis-ci.com/NinjaMiellies/MediaManager) 
QA Synoptic project completed over a week with a weeks advance prep. This Media Manager organises media in a viewable manner, allows creation of playlists and categorisation. 

# Background information
- Whizzy Software develops software components for clients in media industries: music, video, radio, TV etc.
- This project, for one of their clients, is to build a component intended to form part of larger systems which will need to be ported to other platforms.
- The component will be used as a fully-functional prototype that the client can use to test requirements with their own customers.
- The component may run on any execution environment of your choice, on a desktop computer or a mobile computing device.
  - The execution environment should support a local filing system that may contain streamable media files (AAC, MP3, WAV, MP4, AVI, etc).
  - The component should launch as a stand-alone application in that environment.
  - The component does not need to access the network.
- The component should be designed and built to production standards.
- You are advised to get a basic version of the component working first, before adding richer features. Examples of richer features could include:
  - A choice of ways to browse the contents of the organiser.
  - The ability to sort Playlists according to various user-specified criteria.
  - Showing thumbnails of images in the user interface.
  - The ability to change the scope and search again during a session.

# Conceptual model
The UML model below shows the main concepts required by the application and their relationships. Data held in the memory of the organiser, and data loaded and saved by the organiser, should correspond to this conceptual model.

![UML Diagram](Docs/UMLdiagram.png)

- Each MediaFile has a name which is a valid filename (such as “Moonlight Sonata”), a file path (such as “D:\Data\Music\”), a file type (such as “MP3”), and a comment.
- Each MediaFile may be associated with zero or more Categories, each of which is named by a string (such as “Classical”).
- Each MediaFile may be related to zero or one Image, where an Image has a filename and a file path.
- Each MediaFile may appear ordered in any number of PlayLists.

# Use Case Model
The UML Use Case model below shows the interactions that a user may have with the media organiser.

![UML Diagram](Docs/UMLCaseModel.png)

### Specify scope:
- Specify file paths of interest, i.e. the locations in the filing system where the organiser will look for MediaFiles.
- Specify file types of interest, i.e. the types of streamable MediaFiles that the organiser will look for.
- Search for MediaFiles, i.e. within the specified locations, find all the Media Files of the specified types and create corresponding data structures within the organisers internal state.
### Load and save state:
- Save the internal state of the organiser (i.e. the set of MediaFile data, Annotations, Image data and PlayLists) in a text file.
- Load the state of the organiser from a previously saved file.
- You will need to design the format of these files so that your program can save and load them easily. You may consider basing it on XML, JSON or any other format of your choice.
### Specify categories:
- Allow the user to specify a set of Categories which may be associated with MediaFiles.
- The user may add a Category, delete a Category, or rename an existing Category.
### Manage media files:
- The user may select a MediaFile.
- The user may add, edit, or delete a comment about the selected MediaFile.
- The user may add or change an Image related to the selected MediaFile.
- The user may choose or change the Categories associated with the selected MediaFile.
### Make playlists:
- A PlayList refers to a sequence of MediaFiles chosen by the user.
- The user may create and delete PlayLists, change their names, and reorganise their content.

Information contained within this document has been republished under the terms of the Open Government
Licence v3.0 © Crown copyright (2018)
Copyright © BCS 2018
BCS Digital Industries Apprenticeship Synoptic Software Development Technician Project A
QA1
