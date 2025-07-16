# Programming-Theory-Repo

Answer to the *Programming-Theory-Repo* exercise in the Unity *Junior Programmer*
course.

## Design Overview

A simple text based game where the user has to guess which shape will
be selected randomly.

The user is presented with a list of names of possible shapes and 
must select one of them. Following that the game selects one of the 
listed possibilities randomly and the user wins the game if the 
guess was correct otherwise the user looses the game. Finally the user 
also gets a personal message authored by the selected shape. 

## The code

- The program code has a class `Shape` that is the base class for all
the shapes used in the game (inheritance).
- The personal message comes from the method `CreatePersonalMessage()`
that is defined `virtual` in class `Shape` and overridden in each
child shape (abstraction, polymorphism).
- The textual name of a shape is read from a readonly property
`name` (encapsulation).
