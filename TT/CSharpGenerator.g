tree grammar CSharpGenerator;

options
{
	output=template;
	language=CSharp2;
	tokenVocab=Template;
	ASTLabelType=CommonTree;
}

@namespace {TT}

document
	: ^(DOCUMENT stmts+=statement*) -> class(statements={$stmts})
	;

statement
	: getExpr -> {$getExpr.st}
	;

getExpr
	: ^(GET LITERAL) -> print(literal={$LITERAL.text})
	;
