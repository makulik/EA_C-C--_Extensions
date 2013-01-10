///////////////////////////////////////////////////////////
//  Interface1.h
//  Implementation of the Interface Interface1
//  Created on:      19-Dez-2012 21:06:33
//  Original author: Günther
///////////////////////////////////////////////////////////

#if !defined(EA_2CD8100C_1F64_4db7_B9BF_2281C34612A3__INCLUDED_)
#define EA_2CD8100C_1F64_4db7_B9BF_2281C34612A3__INCLUDED_

#include <ea_common_defs.h>


// 'Import' template


class Interface1
{

public:
	// Function pointer declaration
	/* owner = 'Interface1' */
	/* ownerElementType = '' */
	typedef int (*Interface1::CallbackFunc)();

	// Function pointer declaration
	/* owner = 'Interface1' */
	/* ownerElementType = '' */
	typedef int (*StaticFuncPtr)(Interface1*);


	Interface1() {

	}

	virtual ~Interface1() {

	}

	void func1(int p1, char* p2) =0;
	int func2(char* p1) =0;
	virtual int func3() =0;
	virtual int func4(Intrface1::CallbackFunc p1) =0;
	virtual int func5(Intrface1::StaticFuncPtr p1) =0;

};
#endif // !defined(EA_2CD8100C_1F64_4db7_B9BF_2281C34612A3__INCLUDED_)
