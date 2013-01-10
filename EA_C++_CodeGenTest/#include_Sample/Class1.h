///////////////////////////////////////////////////////////
//  Class1.h
//  Implementation of the Class Class1
//  Created on:      25-Nov-2012 02:31:54
//  Original author: Günther
///////////////////////////////////////////////////////////

#if !defined(EA_1B4F6A62_631D_4e21_A97C_3AB6BB4799FE__INCLUDED_)
#define EA_1B4F6A62_631D_4e21_A97C_3AB6BB4799FE__INCLUDED_

#include "Enumeration1.h"
#include "Interface1.h"

// 'Import' template
#include <string>
#include <vector>
#include <framework/foo/Class1.h>


class Class1 : public Interface1
{

public:
	Class1();
	virtual ~Class1();

	std::vector<int> getVector();

private:
	Enumeration1 enumAttr1;
	std::string stdString_attr1;
	framework::Class1 attrFrameworkClass1;

};
#endif // !defined(EA_1B4F6A62_631D_4e21_A97C_3AB6BB4799FE__INCLUDED_)
