///////////////////////////////////////////////////////////
//  Class2.h
//  Implementation of the Class Class2
//  Created on:      24-Nov-2012 23:11:25
//  Original author: Günther
///////////////////////////////////////////////////////////

#if !defined(EA_CD6B2A4D_340C_4775_B90C_16D9370485FE__INCLUDED_)
#define EA_CD6B2A4D_340C_4775_B90C_16D9370485FE__INCLUDED_

#include "Class3.h"
#include "Class4.h"
#include "Class1.h"

// 'Import' template
// 'Connector__Import' template
// 'Connector__Import' template
// 'Connector__Import' template
class Class2 : public Class1
{

public:
	Class2();
	virtual ~Class2();
	Class3 *m_Class3;
	Class4 *m_Class4;

};
#endif // !defined(EA_CD6B2A4D_340C_4775_B90C_16D9370485FE__INCLUDED_)
