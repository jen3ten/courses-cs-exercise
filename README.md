# Repository Pattern Branch

* Repositories are a place to hold your domain ("models") in memory.  They provide one place for common retrieval actions, such as GetAll() and GetById()
* IIS -> Controller -> (Repository added here breaks dependency between Controller and EF) -> EF (queries on your tables) -> dB (your tables)

## Workshop Instructions
 1. 
