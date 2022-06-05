# Game-theortic Utility Tree (GUT)
## Abstract
Underlying relationships among multiagent systems (MAS) in hazardous scenarios can be represented as Game-theoretic models. This paper proposes a new hierarchical network-based model called Game-theoretic Utility Tree (GUT), which decomposes high-level strategies into executable low-level actions for cooperative MAS decisions. It combines with a new payoff measure based on agent needs for real-time strategy games. We present an Explore game domain, where we measure the performance of MAS achieving tasks from the perspective of balancing the success probability and system costs. We evaluate the GUT approach against state-of-the-art methods that greedily rely on rewards of the composite actions. Conclusive results on extensive numerical simulations indicate that GUT can organize more complex relationships among MAS cooperation, helping the group achieve challenging tasks with lower costs and higher winning rates. We also demonstrated the applicability of the GUT using the Robotarium platform, which is a simulator-hardware testbed for verifying multi-robot system algorithms.

> Paper: [A game-theoretic utility network for cooperative multi-agent decisions in adversarial environments](https://arxiv.org/abs/2004.10950)

> Extend to Pursuit Domain Paper: [Game-theoretic Utility Tree for Multi-Robot Cooperative Pursuit Strategy](https://github.com/RickYang2016/Gut-Pursuit-Domain-Robotarium-ISR2022/blob/main/Gut-Pursuit-Domain-Robotarium-ISR2022Paper.pdf)

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

### Theorem (GUT Decision)
<img src="http://latex.codecogs.com/svg.latex? Supposing~the~GUT~for~the~ally~group~has~w~levels~of~action~decomposition~together,~making~a"/>
<img src="http://latex.codecogs.com/svg.latex? group~strategy~s_A = \{s_A^1, s_A^2, ... , s_{A}^w\},~where~s_A^i~represents~the~i^{th}~level~substrategy~in~the~ally~group"/>
<img src="http://latex.codecogs.com/svg.latex? strategy~space.~Then,~we~can~show~that~agent~group~A~using~GUT~against~adversary~B~will~have~at"/>

## Evaluation through Simulation Studies


## Demontration Explore Domain in Robotarium


## Conclusion
We introduce a new Game-theoretic Utility Tree (GUT) for multiagent decision-making in adversarial scenarios. We then present an example real-time strategy game called Explore Domain where a group of explorer agents tackles physically attacking adversary agents. Through extensive numerical simulations, we analyze GUT and compare it against a state-of-the-art cooperative decision-making approach, such as the greedy selection method in QMIX. We verified the effectiveness of GUT through two types of experiments involving interaction and information prediction between the agents. The results showed that the GUT could organize more complex relationships among MAS cooperation, helping the group achieve more challenging tasks with lower costs and higher winning rates. 

Further, we verified the effectiveness of the GUT in the real robot application through the implementation of the Explore Domain on the Robotarium hardware-simulator multiagent testbed and compared it with the random and greedy approaches in three scenarios. These results demonstrated that the GUT could effectively organize multiagent cooperation strategies, enabling a group with fewer advantages to achieve higher performance.
