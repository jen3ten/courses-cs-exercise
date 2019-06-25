# courses-cs-exercise

This project and its branches demonstrates the MVC pattern, repository pattern, EF, forms, and tag helpers.  The initial skeleton project can be found in the master branch.  All subsequent branches add one feature and build off of each other.  The order of branches is listed below, with an explanation of the workshop following.

## Repository Pattern Branch

* Repositories are a place to hold your domain ("models") in memory.  
* They provide one place for common retrieval actions, such as GetAll() and GetById()
* IIS -> Controller -> (Repository added here breaks dependency between Controller and EF) -> EF (queries on your tables) -> dB (your tables)

### Repository Workshop Instructions
 1. Add CourseRepository with seed data and list of courses
     * CourseList is a public property of CourseRepository
     * Add 3 Courses to the list in CourseRepository constructor
 2. Modify CourseController to use CourseRepository
     * For now, set model to equal one of the items from the list
 3. Add a generic IRepository with GetAll() and GetById() methods
 4. CourseRepository implements IRepository
     * Add code for GetAll() and GetById() methods
 5. Modify CourseController and Index View to get all courses and show them in the View
