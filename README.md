# Add Tests Branch

## File Structure
- Course Model has properties and constructors
- Course Controller has Index() action which creates new model and passes to view
- Index View displays Courses List

## Workshop Instructions
1. Start with Courses starter project from main branch.
2. Add CourseControllerTests
  * Index_Returns_A_View
  * Index_Passes_Course_Model_To_View
3. Refactor CourseControllerTests to remove duplication
4. Add CourseTests
  - Course_Constructor_Sets_Id_on_Course_Model
  - Course_Constructor_Sets_Name_on_Course_Model
  - Course_Constructor_Sets_Description_on_Course_Model
5. Refactor CourseTests to remove duplication
6. Set up Index View to use the model object
  - @model razor syntax allows you to use a model object anywhere in the view
