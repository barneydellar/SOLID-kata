Dependency Inversion
====================

The business logic currently depends on the database access code. So any changes to the database access force a change onto the business logic. 

Add in interfaces to the business logic for the database access to use.

And then look at Hexagonal Architechture.