# MecrispForth_buzzer
Forth words to use a buzzer and play some music

Install:
- install Mecrisp Forth
- install pwm.fs from jcw
- !s buzzer.fs

examples:

- Play tone a for 1s
 + 440 1000 tone

- demo play tunes
 + m1 play

- play Ode an die Freude
 + !s notes.fs \ installs note definitions
 + !s odeandiefreude.fs
 + ode play


