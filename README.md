# Shape Factory App

The Shape Factory App is a C# application that demonstrates the implementation of the **Factory Design Pattern**. The application allows shapes to be created dynamically based on user input without exposing the object creation logic, promoting loose coupling and extensibility.

---

## Project Overview

This project was developed to illustrate how the Factory Pattern can be used to manage object creation in an object-oriented system. Instead of instantiating concrete shape classes directly, the application uses a factory class to determine which shape object to create at runtime.

The Shape Factory App highlights key object-oriented principles such as abstraction, encapsulation, and polymorphism.

---

## Key Concepts Demonstrated

- Factory Design Pattern
- Object-Oriented Programming (OOP)
- Abstraction through interfaces or abstract classes
- Polymorphism
- Separation of concerns

---

## Application Structure

- **IShape / Shape (Interface or Abstract Class)**  
  Defines a common contract for all shapes.

- **Concrete Shape Classes**  
  Examples may include:
  - Circle  
  - Rectangle  
  - Square  

- **ShapeFactory**  
  Responsible for creating shape objects based on input parameters.

- **Client/Application Layer**  
  Requests shape objects from the factory and uses them without knowing their concrete implementation.

---

## Technologies Used

- **C#**
- **.NET**
- **Visual Studio**

---

## What I Learned

- How to implement and apply the Factory Design Pattern
- How design patterns improve flexibility and maintainability
- Reducing tight coupling between classes
- Writing cleaner and more scalable object-oriented code

---

## Future Improvements

- Add more shape types without modifying existing logic
- Introduce a GUI for shape selection and visualization
- Combine with other design patterns (e.g. Singleton or Strategy)
- Add unit tests for factory logic

---

## Notes

This project was created for educational purposes to demonstrate design patterns in C#. It focuses on clean architecture and design principles rather than advanced UI or graphics.

---

## Author

**Atlehang Tloome**  
Bachelor of Computer and Information Sciences – Application Development  
