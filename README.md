# Implicit and Explicit Interface Implementation

## Implicit Interface
With implicit interface implementations, the members of the interface are public with the same signature of the method as defined in the interface and the same return type. 
This is how you normally implement interfaces.

## Explicit Interface
With explicit implementations, in the class the interface members are not declared as public members and cannot be directly accessed using an instance of the class, 
but a cast to the interface allows accessing the members. 