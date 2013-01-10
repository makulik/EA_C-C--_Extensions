/*
 * Interface1.h
 *
 *  Created on: 30.11.2012
 *      Author: Admin
 */

#ifndef INTERFACE1_H_
#define INTERFACE1_H_

#include <ea_common_defs.h>

struct Interface1;

EA_func_ptr_definition(int,CallbackFunc,(struct Interface1*));

EA_func_ptr_definition(void,Func1Ptr,(struct Interface1*, int, char*));
EA_func_ptr_definition(int,Func2Ptr,(struct Interface1*, char*));
EA_func_ptr_definition(int,Func3Ptr,(struct Interface1*, CallbackFunc));

typedef struct Interface1
{

    Func1Ptr func1;
    Func2Ptr func2;
    Func3Ptr func3;

    void* instance;
};

/* The following extern declarations are only dummies to satisfy code reverse engineering,
 * and never should be called.
 */
extern void Func1(struct Interface1* self, int p1, char* p2) = 0;
extern int func2(struct Interface1* self, char*) = 0;
extern int func3(struct Interface1* self, CallbackFunc p1) = 0;

#endif /* INTERFACE1_H_ */
