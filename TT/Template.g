grammar Template;

options
{
	output=AST;
	ASTLabelType=CommonTree;
	language=CSharp2;
}

tokens {
	GET;
	PRINT;
	DOCUMENT;
}

@lexer::namespace {TT}
@parser::namespace {TT}


TSTART	:	'[%' WS?;
TSTOP	:	WS? '%]';
WS	:	('\r'|'\n'|'\t'|' ')+ { $channel=HIDDEN; };
QUOTE	:	'"';
SQUOTE	:	'\'';
ILITERAL:	QUOTE .* QUOTE;
LITERAL	:	SQUOTE .* SQUOTE;
SET	:	'SET';
CALL	:	'CALL';
DEFAULT	:	'DEFAULT';
INSERT	:	'INSERT';
PROCESS	:	'PROCESS';
INCLUDE	:	'INCLUDE';
WRAPPER	:	'WRAPPER';
BLOCK	:	'BLOCK';
FOREACH	:	'FOREACH';
WHILE	:	'WHILE';
IF	:	'IF';
UNLESS	:	'UNLESS';
ELSIF	:	'ELSIF';
ELSE	:	'ELSE';
SWITCH	:	'SWITCH';
CASE	:	'CASE';
MACRO	:	'MACRO';
FILTER	:	'FILTER';
USE	:	'USE';
PERL	:	'PERL';
RAWPERL	:	'RAWPERL';
TRY	:	'TRY';
THROW	:	'THROW';
CATCH	:	'CATCH';
FINAL	:	'FINAL';
NEXT	:	'NEXT';
LAST	:	'LAST';
RETURN	:	'RETURN';
STOP	:	'STOP';
TAGS	:	'TAGS';
COMMENTS:	'COMMENTS';
ID	:	('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'_')*;
DIGIT	:	('0'..'9');
NUMBER	:	DIGIT+;
DECIMAL	:	DIGIT '.' DIGIT;
ADD	:	'+';
SUB	:	'-';
MULT	:	'*';
DIV	:	'/';
ASSIGN	:	'=';
EQUAL	:	'==';
CHAR	:	('\u0000'..'\uffff');




document
	: block* -> ^(DOCUMENT block*)
	;

block
	: TSTART! statement TSTOP!
	;

statement 
	: getExpr
	| setExpr
	;

getExpr
	: 'GET'? ID       -> ^(GET ID)
	| 'GET'? LITERAL  -> ^(GET LITERAL)
	| 'GET'? ILITERAL -> ^(GET ILITERAL)
	;

setExpr
	: SET? ID ASSIGN (ID|LITERAL|ILITERAL|NUMBER|DECIMAL)
	;