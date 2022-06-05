# Game-theortic Utility Tree (GUT)
## Abstract
Underlying relationships among multiagent systems (MAS) in hazardous scenarios can be represented as Game-theoretic models. This paper proposes a new hierarchical network-based model called Game-theoretic Utility Tree (GUT), which decomposes high-level strategies into executable low-level actions for cooperative MAS decisions. It combines with a new payoff measure based on agent needs for real-time strategy games. We present an Explore game domain, where we measure the performance of MAS achieving tasks from the perspective of balancing the success probability and system costs. We evaluate the GUT approach against state-of-the-art methods that greedily rely on rewards of the composite actions. Conclusive results on extensive numerical simulations indicate that GUT can organize more complex relationships among MAS cooperation, helping the group achieve challenging tasks with lower costs and higher winning rates. We also demonstrated the applicability of the GUT using the Robotarium platform, which is a simulator-hardware testbed for verifying multi-robot system algorithms.

> Paper: [A game-theoretic utility network for cooperative multi-agent decisions in adversarial environments](https://arxiv.org/abs/2004.10950)

> Extend to Pursuit Domain in Robotarium Paper: [Game-theoretic Utility Tree for Multi-Robot Cooperative Pursuit Strategy](https://github.com/RickYang2016/Gut-Pursuit-Domain-Robotarium-ISR2022/blob/main/Gut-Pursuit-Domain-Robotarium-ISR2022Paper.pdf)

> Structure of the Game-theoretic Utility Tree (GUT)
    <div align = center>
    <img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/gut1.png" height="210" alt="Hopper-V2 3SABC"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/gut2.png" height="210" alt="Hopper-V2 3SABC Video"/>
    </div>

## Approach Overview
### Adversarial Agent Definition
<div align = center>
    <img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/frontpic.png" height="275" alt="Hopper-V2 3SABC"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/adversary.png" height="275" alt="Hopper-V2 3SABC Video"/>
</div>

### Explore Domain
<div align = center>
    <img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/overview.png" height="285" alt="Hopper-V2 3SABC"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/explore.png" height="285" alt="Hopper-V2 3SABC Video"/>
</div>

### GUT Decision Theorem
<img src="http://latex.codecogs.com/svg.latex? Supposing~the~GUT~for~the~ally~group~has~w~levels~of~action~decomposition~together,~making~a"/>
<img src="http://latex.codecogs.com/svg.latex? group~strategy~s_A = \{s_A^1, s_A^2, ... , s_{A}^w\},~where~s_A^i~represents~the~i^{th}~level~substrategy~in~the~ally~group"/>
<img src="http://latex.codecogs.com/svg.latex? strategy~space.~Then,~we~can~show~that~agent~group~A~using~GUT~against~adversary~B~will~have~at"/>
<img src="http://latex.codecogs.com/svg.latex? least~one~dominant~strategy~series~s_A^* = (s_A^1*, s_A^2*, ... , s_A^w*),~which~will~enable~agents~A~collectively"/>
<img src="http://latex.codecogs.com/svg.latex? execute~an~optimal~strategy~s_A^*~to~win~against~adversary~B,~promising~a~solution~to~the~problem"/>
<img src="http://latex.codecogs.com/svg.latex? as~below:"/>

<div align = center>
<img src="http://latex.codecogs.com/svg.latex? s_e^* = \underset{s_e \in {S_e}} \arg \max [W(s_e | T, S_a, N_e) - \sum_{i=1}^{\alpha} C_i(s_{i} | T, s_e, N_{i})]"/>
</div>

Note: Please check the [paper](https://arxiv.org/abs/2004.10950) for more details about the proof of the GUT Decision Theorem.

## Evaluation through Simulation Studies
### Experiment Platform
Considering cross-platform, scalability, and efficiency of the simulations, we chose the [Unity](https://unity.com/) game engine to simulate the Explorers and Aliens Game and selected [Gambit](http://www.gambit-project.org/) toolkit for calculating each level's Nash Equilibrium in the GUT.

> Note: Gambit is an open-source collection of tools for doing computation in game theory which can build, analyze, and explore game models.

### Experiment Setting in the Explore Domain
In this domain, the explorers will group in patrol formation to explore the circumstance when they do not detect aliens. They are provided with the location of the treasure and always choose the shortest path to the goal, then circle around the treasure location once reached. In the whole process, explorers present a kind of global behaviors using collective rationality and caring about their group interest. In contrast, aliens are more powerful than explorers but show only self-interest and do not cooperate within themselves. 

For this game implementation, we decompose the team strategy into three levels. 
* At the highest strategy level, the explorer agents decide "what" to do (attack or defend) under the presence of an adversary, using their teaming needs as the utility function expressed through a win probability function for a specific Attach/Defend strategy combination. This helps make group-aware decisions to maximize the chance of collectively reaching the treasure as a team while minimizing the overall team costs.
* At the second strategy level (deciding "who" to attack or defend against), the explorers use their collective basic needs expressed as a function of their current energy level in their payoff table. This helps the decision energy-aware. 
* At the lowest strategy level (deciding "how" to attack/defend against), the explorers use their collective safety needs expressed through their health status (HP value) to calculate the payoff at this level. This ensures the decision is safety-aware since safety is the highest priority of needs as per the needs hierarchy defined. 
<div align = center>
    <img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/matrix.png" height="300" alt="Hopper-V2 3SABC"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/scenario.png" height="300" alt="Hopper-V2 3SABC Video"/>
</div>

> Note: The design of the utility functions at each level is critical to determine whether an agent can calculate reasonable tactics.

### Visual Representation: Without and With Unintentional Adversaries
<div align = center>
    <img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/video.gif" height="210" alt="Hopper-V2 3SABC">   <img src="https://github.com/RickYang2016/PhD-Dissertation-SASS/blob/main/figures/gut_s.gif" height="210" alt="Hopper-V2 3SABC Video"/>
</div>

> Note: Please check the [Link](https://youtu.be/SjoxazLar6I) for the full video representation.

## Demontration Explore Domain in Robotarium
To demonstrate the GUT on the multi-robot applications, we implement our method in the [Robotarium](https://www.robotarium.gatech.edu/) platform, a remote-accessible multi-robot experiment testbed that supports controlling up to 20 robots simultaneously on a 3.2m x 2.0m large rectangular area. Each robot has the dimensions 0.11 m x 0.1 m x 0.07 m in the testbed. The platform also provides a simulator helping users test their code, which can rapidly prototype their distributed control algorithms and receive feedback about their implementation feasibility before sending them to be executed by the robots on the Robotarium. 
<div align = center>
    <img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/matrix1.png" height="143" alt="Hopper-V2 3SABC"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/1eVS2a.png" height="143" alt="Hopper-V2 3SABC Video"/>
</div>

Our Robotarium experiments consider four different strategies for the explorer team: attacking and changing direction, attacking and changing speed, defending and changing direction, and defending and changing speed. We decompose this strategy set into two levels for GUT implementation in Robotarium: Level 1 considers deciding attack or defend; and Level 2 considers changing direction or speed for a single explorer game while it considers triangle or diamond formation shape for a multiple explorer game. Two different tactics payoff matrices are designed in Level 2 to differentiate the strategies between single-agent and multiagent cooperation.

### one explorer vs. one alien
<div align = center>
<img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/s1v1.gif" height="213" alt="Hopper-V2 3SABC Video"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/r1v1.gif" height="213" alt="Hopper-V2 3SABC"/>
</div>

### one explorer vs. two aliens
<div align = center>
<img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/s1v2.gif" height="213" alt="Hopper-V2 3SABC Video"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/r1v2.gif" height="213" alt="Hopper-V2 3SABC"/>
</div>

### four explorers vs. three aliens
<div align = center>
<img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/s4v3.gif" height="213" alt="Hopper-V2 3SABC Video"><img src="https://github.com/RickYang2016/Game-theortic-Utility-Tree--GUT/blob/master/figures/r4v3.gif" height="213" alt="Hopper-V2 3SABC"/>
</div>


## Conclusion
We introduce a new Game-theoretic Utility Tree (GUT) for multiagent decision-making in adversarial scenarios. We then present an example real-time strategy game called Explore Domain where a group of explorer agents tackles physically attacking adversary agents. Through extensive numerical simulations, we analyze GUT and compare it against a state-of-the-art cooperative decision-making approach, such as the greedy selection method in QMIX. We verified the effectiveness of GUT through two types of experiments involving interaction and information prediction between the agents. The results showed that the GUT could organize more complex relationships among MAS cooperation, helping the group achieve more challenging tasks with lower costs and higher winning rates. 

Further, we verified the effectiveness of the GUT in the real robot application through the implementation of the Explore Domain on the Robotarium hardware-simulator multiagent testbed and compared it with the random and greedy approaches in three scenarios. These results demonstrated that the GUT could effectively organize multiagent cooperation strategies, enabling a group with fewer advantages to achieve higher performance.
