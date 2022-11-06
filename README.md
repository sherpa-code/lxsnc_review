# lxsnc_review

A Unity application that satisfies the below problem.
---
Use any and all resources that would be appropriate and available to you as an employee of X.

You must create a 3D scene in Unity that allows a user to administer some medicine via a needle. The scene should be a hospital room. It should contain a table and a patient.
When the application starts, three items should spawn in a random order: a syringe, a vial 
(with medicine inside), and a box of gloves.

User Interactions:
1) Take out a glove from the glove box and drop them on their other hand to put them on 
2) Pick up the syringe and attach it to the vial
3) Separate the syringe and vial
4) Insert the assembled syringe into the patient's arm/deltoid

- Trying 1 to 4 out of order should tell the user of their error
- A UI with assembly results information should be presented upon completion 
- There should be a JSON record of # of attempts before successful assembly for last 3
times the scenario is completed 
- Upon completion, the scene should reset and allow the user to restart the scenario

Requested features:
- Collision Detection
- Event and Unity Events
- UI Design and Interactions
- Audio and/or Visual Cues
- VR Interaction Toolkit Integration
- Parsing a JSON file