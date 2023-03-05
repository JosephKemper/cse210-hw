Other than the extra details like how many times and the bonus points, each goal has the same dialog for its starting. What needs to happen to allow that to exist? 
The SetGoal method would need to have a basic structure to it that could be used by all goal types, but would also need to be able to be overridden by the ChecklistGoal, which needs a different intro structure. 
