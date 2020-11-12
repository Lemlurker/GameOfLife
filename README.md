# Forest fire


this is the modified forest fire project which includes the additional features for wind and rain that affect the fire spreading, the two changes I implemented was wind which worked through modifying the probability of fire catching upwind and down wind and rain which, after a delay and depending on random numbers reduces the probability of the fire spreading significantly. The wind strength and vector is calculated through a random number between 1&3 and a vector of -1 to 1 in each direction, the check alight neighbours then determines if the alight neighbours are up wind or down wind and modifies the probability of catching alight accordingly. For the rain a lot of work went into accurate and concise debugging which included descriptions of the probabilities, a forecast, weather or not it would rain and a count down to rain start, in a final product these values would be suppressed instead of printed ton the console but without visual cues such as weather in the scene debugging is the easiest way to check things are working.  


