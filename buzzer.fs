( start buzzer: ) here dup hex.

\ needs pwm.fs from jcw
\ don't forget to start the systicks-hz, else it will hang 

PB1 constant BUZ \ Port for buzzer, must be a pwm port

\ this is just a simple square wave 
: tone ( length freq - - ) \ length in ms, freq in Hz 
  buz pwm-init 500 buz pwm dup ms 0 buz pwm  4 / ms
;

\ word to play music, see below and inside the bigger examples
: play ( addr - - )  
    begin
	dup @ \ note holen
	dup 9999 <>
    while
	    swap 1 cells + dup @ \ get length
	    1200 swap / \ basis 1.2s
	    rot
	    dup 0= if
		drop ms \ pause
	    else
		tone \ beeeep
	    then
	    1 cells +
    repeat
;
    


\ some demos
create m1
440 , 4 ,
196 , 8 ,
196 , 8 ,
220 , 4 ,
196 , 4 ,
0   , 4 ,
247 , 4 ,
440 , 4 ,
9999
,

create m2
523 , 4 ,
493 , 4 ,
392 , 4 ,
523 , 8 ,
493 , 8 ,
329 , 4 ,
0   , 2 ,
523 , 4 ,
261 , 4 ,
392 , 4 ,
440 , 8 ,
523 , 8 ,
9999
,

create m3
294 , 4 ,
440 , 4 ,
349 , 8 ,
261 , 4 ,
294 , 4 ,
440 , 4 ,
294 , 4 ,
261 , 4 ,
349 , 4 ,
294 , 4 ,
440 , 4 ,
261 , 4 ,
294 , 4 ,
440 , 4 ,
349 , 8 , 
9999
,


( end buzzer: ) here dup hex.
( size buzzer: ) swap - hex.

