///////////////////////////////////////////////////////////
//  Class1.h
//  Implementation of the Class Class1
//  Created on:      19-Dez-2012 21:06:32
//  Original author: Günther
///////////////////////////////////////////////////////////

#if !defined(EA_2B323645_C6D4_4382_B5DA_6BA095072147__INCLUDED_)
#define EA_2B323645_C6D4_4382_B5DA_6BA095072147__INCLUDED_

#include <ea_common_defs.h>


#include "Interface1.h"

// 'Import' template


class Class1 : public Interface1
{

public:
	// Function pointer declaration
	/* owner = 'Class1' */
	/* ownerElementType = '' */
	typedef void (*Class1::CallbackFunc)();

	Class1();
	~Class1();
	virtual void func1(int p1, char* p2);
	virtual int func2(char* p1);
	virtual int func4(Interface1::CallbackFunc p1);
	virtual int func5(Interface1::StaticFuncPtr p1);
	int func6(Class1::CallbackFunc p1);
	virtual int func4(Intrface1::CallbackFunc p1);
	virtual int func5(Intrface1::StaticFuncPtr p1);

};
#endif // !defined(EA_2B323645_C6D4_4382_B5DA_6BA095072147__INCLUDED_)
