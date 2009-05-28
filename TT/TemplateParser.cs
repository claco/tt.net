// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 TT\\Template.g 2009-05-27 20:51:20

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

namespace TT
{
public partial class TemplateParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"GET", 
		"PRINT", 
		"DOCUMENT", 
		"WS", 
		"TSTART", 
		"TSTOP", 
		"QUOTE", 
		"SQUOTE", 
		"ILITERAL", 
		"LITERAL", 
		"SET", 
		"CALL", 
		"DEFAULT", 
		"INSERT", 
		"PROCESS", 
		"INCLUDE", 
		"WRAPPER", 
		"BLOCK", 
		"FOREACH", 
		"WHILE", 
		"IF", 
		"UNLESS", 
		"ELSIF", 
		"ELSE", 
		"SWITCH", 
		"CASE", 
		"MACRO", 
		"FILTER", 
		"USE", 
		"PERL", 
		"RAWPERL", 
		"TRY", 
		"THROW", 
		"CATCH", 
		"FINAL", 
		"NEXT", 
		"LAST", 
		"RETURN", 
		"STOP", 
		"TAGS", 
		"COMMENTS", 
		"ID", 
		"DIGIT", 
		"NUMBER", 
		"DECIMAL", 
		"ADD", 
		"SUB", 
		"MULT", 
		"DIV", 
		"ASSIGN", 
		"EQUAL", 
		"CHAR", 
		"'GET'"
    };

    public const int WHILE = 23;
    public const int CASE = 29;
    public const int CHAR = 55;
    public const int RAWPERL = 34;
    public const int SUB = 50;
    public const int ID = 45;
    public const int EOF = -1;
    public const int TSTART = 8;
    public const int IF = 24;
    public const int T__56 = 56;
    public const int QUOTE = 10;
    public const int TSTOP = 9;
    public const int FINAL = 38;
    public const int COMMENTS = 44;
    public const int INSERT = 17;
    public const int DOCUMENT = 6;
    public const int EQUAL = 54;
    public const int INCLUDE = 19;
    public const int RETURN = 41;
    public const int GET = 4;
    public const int NEXT = 39;
    public const int DIGIT = 46;
    public const int LAST = 40;
    public const int UNLESS = 25;
    public const int ILITERAL = 12;
    public const int ADD = 49;
    public const int SWITCH = 28;
    public const int DEFAULT = 16;
    public const int ELSE = 27;
    public const int NUMBER = 47;
    public const int TAGS = 43;
    public const int SET = 14;
    public const int LITERAL = 13;
    public const int STOP = 42;
    public const int MULT = 51;
    public const int SQUOTE = 11;
    public const int WRAPPER = 20;
    public const int PRINT = 5;
    public const int TRY = 35;
    public const int PERL = 33;
    public const int WS = 7;
    public const int DECIMAL = 48;
    public const int BLOCK = 21;
    public const int ASSIGN = 53;
    public const int FILTER = 31;
    public const int FOREACH = 22;
    public const int CALL = 15;
    public const int ELSIF = 26;
    public const int USE = 32;
    public const int DIV = 52;
    public const int PROCESS = 18;
    public const int CATCH = 37;
    public const int MACRO = 30;
    public const int THROW = 36;

    // delegates
    // delegators



        public TemplateParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public TemplateParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return TemplateParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "TT\\Template.g"; }
    }


    public class document_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "document"
    // TT\\Template.g:73:1: document : ( block )* -> ^( DOCUMENT ( block )* ) ;
    public TemplateParser.document_return document() // throws RecognitionException [1]
    {   
        TemplateParser.document_return retval = new TemplateParser.document_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.block_return block1 = default(TemplateParser.block_return);


        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        try 
    	{
            // TT\\Template.g:74:2: ( ( block )* -> ^( DOCUMENT ( block )* ) )
            // TT\\Template.g:74:4: ( block )*
            {
            	// TT\\Template.g:74:4: ( block )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == TSTART) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // TT\\Template.g:74:4: block
            			    {
            			    	PushFollow(FOLLOW_block_in_document477);
            			    	block1 = block();
            			    	state.followingStackPointer--;

            			    	stream_block.Add(block1.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements



            	// AST REWRITE
            	// elements:          block
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 74:11: -> ^( DOCUMENT ( block )* )
            	{
            	    // TT\\Template.g:74:14: ^( DOCUMENT ( block )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DOCUMENT, "DOCUMENT"), root_1);

            	    // TT\\Template.g:74:25: ( block )*
            	    while ( stream_block.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_block.NextTree());

            	    }
            	    stream_block.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "document"

    public class block_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "block"
    // TT\\Template.g:77:1: block : TSTART statement TSTOP ;
    public TemplateParser.block_return block() // throws RecognitionException [1]
    {   
        TemplateParser.block_return retval = new TemplateParser.block_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken TSTART2 = null;
        IToken TSTOP4 = null;
        TemplateParser.statement_return statement3 = default(TemplateParser.statement_return);


        CommonTree TSTART2_tree=null;
        CommonTree TSTOP4_tree=null;

        try 
    	{
            // TT\\Template.g:78:2: ( TSTART statement TSTOP )
            // TT\\Template.g:78:4: TSTART statement TSTOP
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	TSTART2=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_block498); 
            	PushFollow(FOLLOW_statement_in_block501);
            	statement3 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement3.Tree);
            	TSTOP4=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_block503); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "block"

    public class statement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // TT\\Template.g:81:1: statement : ( getExpr | setExpr );
    public TemplateParser.statement_return statement() // throws RecognitionException [1]
    {   
        TemplateParser.statement_return retval = new TemplateParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.getExpr_return getExpr5 = default(TemplateParser.getExpr_return);

        TemplateParser.setExpr_return setExpr6 = default(TemplateParser.setExpr_return);



        try 
    	{
            // TT\\Template.g:82:2: ( getExpr | setExpr )
            int alt2 = 2;
            switch ( input.LA(1) ) 
            {
            case ILITERAL:
            case LITERAL:
            case 56:
            	{
                alt2 = 1;
                }
                break;
            case ID:
            	{
                int LA2_2 = input.LA(2);

                if ( (LA2_2 == ASSIGN) )
                {
                    alt2 = 2;
                }
                else if ( (LA2_2 == TSTOP) )
                {
                    alt2 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d2s2 =
                        new NoViableAltException("", 2, 2, input);

                    throw nvae_d2s2;
                }
                }
                break;
            case SET:
            	{
                alt2 = 2;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // TT\\Template.g:82:4: getExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_getExpr_in_statement516);
                    	getExpr5 = getExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, getExpr5.Tree);

                    }
                    break;
                case 2 :
                    // TT\\Template.g:83:4: setExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_setExpr_in_statement521);
                    	setExpr6 = setExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, setExpr6.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class getExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "getExpr"
    // TT\\Template.g:86:1: getExpr : ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) );
    public TemplateParser.getExpr_return getExpr() // throws RecognitionException [1]
    {   
        TemplateParser.getExpr_return retval = new TemplateParser.getExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal7 = null;
        IToken ID8 = null;
        IToken string_literal9 = null;
        IToken LITERAL10 = null;
        IToken string_literal11 = null;
        IToken ILITERAL12 = null;

        CommonTree string_literal7_tree=null;
        CommonTree ID8_tree=null;
        CommonTree string_literal9_tree=null;
        CommonTree LITERAL10_tree=null;
        CommonTree string_literal11_tree=null;
        CommonTree ILITERAL12_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ILITERAL = new RewriteRuleTokenStream(adaptor,"token ILITERAL");

        try 
    	{
            // TT\\Template.g:87:2: ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) )
            int alt6 = 3;
            switch ( input.LA(1) ) 
            {
            case 56:
            	{
                switch ( input.LA(2) ) 
                {
                case ILITERAL:
                	{
                    alt6 = 3;
                    }
                    break;
                case ID:
                	{
                    alt6 = 1;
                    }
                    break;
                case LITERAL:
                	{
                    alt6 = 2;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d6s1 =
                	        new NoViableAltException("", 6, 1, input);

                	    throw nvae_d6s1;
                }

                }
                break;
            case ID:
            	{
                alt6 = 1;
                }
                break;
            case LITERAL:
            	{
                alt6 = 2;
                }
                break;
            case ILITERAL:
            	{
                alt6 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // TT\\Template.g:87:4: ( 'GET' )? ID
                    {
                    	// TT\\Template.g:87:4: ( 'GET' )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 56) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:87:4: 'GET'
                    	        {
                    	        	string_literal7=(IToken)Match(input,56,FOLLOW_56_in_getExpr532);  
                    	        	stream_56.Add(string_literal7);


                    	        }
                    	        break;

                    	}

                    	ID8=(IToken)Match(input,ID,FOLLOW_ID_in_getExpr535);  
                    	stream_ID.Add(ID8);



                    	// AST REWRITE
                    	// elements:          ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 87:20: -> ^( GET ID )
                    	{
                    	    // TT\\Template.g:87:23: ^( GET ID )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GET, "GET"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // TT\\Template.g:88:4: ( 'GET' )? LITERAL
                    {
                    	// TT\\Template.g:88:4: ( 'GET' )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 56) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:88:4: 'GET'
                    	        {
                    	        	string_literal9=(IToken)Match(input,56,FOLLOW_56_in_getExpr554);  
                    	        	stream_56.Add(string_literal9);


                    	        }
                    	        break;

                    	}

                    	LITERAL10=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_getExpr557);  
                    	stream_LITERAL.Add(LITERAL10);



                    	// AST REWRITE
                    	// elements:          LITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 88:20: -> ^( GET LITERAL )
                    	{
                    	    // TT\\Template.g:88:23: ^( GET LITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GET, "GET"), root_1);

                    	    adaptor.AddChild(root_1, stream_LITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // TT\\Template.g:89:4: ( 'GET' )? ILITERAL
                    {
                    	// TT\\Template.g:89:4: ( 'GET' )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 56) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:89:4: 'GET'
                    	        {
                    	        	string_literal11=(IToken)Match(input,56,FOLLOW_56_in_getExpr571);  
                    	        	stream_56.Add(string_literal11);


                    	        }
                    	        break;

                    	}

                    	ILITERAL12=(IToken)Match(input,ILITERAL,FOLLOW_ILITERAL_in_getExpr574);  
                    	stream_ILITERAL.Add(ILITERAL12);



                    	// AST REWRITE
                    	// elements:          ILITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 89:20: -> ^( GET ILITERAL )
                    	{
                    	    // TT\\Template.g:89:23: ^( GET ILITERAL )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GET, "GET"), root_1);

                    	    adaptor.AddChild(root_1, stream_ILITERAL.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "getExpr"

    public class setExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "setExpr"
    // TT\\Template.g:92:1: setExpr : ( SET )? ID ASSIGN ( ID | LITERAL | ILITERAL | NUMBER | DECIMAL ) ;
    public TemplateParser.setExpr_return setExpr() // throws RecognitionException [1]
    {   
        TemplateParser.setExpr_return retval = new TemplateParser.setExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SET13 = null;
        IToken ID14 = null;
        IToken ASSIGN15 = null;
        IToken set16 = null;

        CommonTree SET13_tree=null;
        CommonTree ID14_tree=null;
        CommonTree ASSIGN15_tree=null;
        CommonTree set16_tree=null;

        try 
    	{
            // TT\\Template.g:93:2: ( ( SET )? ID ASSIGN ( ID | LITERAL | ILITERAL | NUMBER | DECIMAL ) )
            // TT\\Template.g:93:4: ( SET )? ID ASSIGN ( ID | LITERAL | ILITERAL | NUMBER | DECIMAL )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// TT\\Template.g:93:4: ( SET )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == SET) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // TT\\Template.g:93:4: SET
            	        {
            	        	SET13=(IToken)Match(input,SET,FOLLOW_SET_in_setExpr593); 
            	        		SET13_tree = (CommonTree)adaptor.Create(SET13);
            	        		adaptor.AddChild(root_0, SET13_tree);


            	        }
            	        break;

            	}

            	ID14=(IToken)Match(input,ID,FOLLOW_ID_in_setExpr596); 
            		ID14_tree = (CommonTree)adaptor.Create(ID14);
            		adaptor.AddChild(root_0, ID14_tree);

            	ASSIGN15=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_setExpr598); 
            		ASSIGN15_tree = (CommonTree)adaptor.Create(ASSIGN15);
            		adaptor.AddChild(root_0, ASSIGN15_tree);

            	set16 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= ILITERAL && input.LA(1) <= LITERAL) || input.LA(1) == ID || (input.LA(1) >= NUMBER && input.LA(1) <= DECIMAL) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set16));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setExpr"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_block_in_document477 = new BitSet(new ulong[]{0x0000000000000102UL});
    public static readonly BitSet FOLLOW_TSTART_in_block498 = new BitSet(new ulong[]{0x0100200000007000UL});
    public static readonly BitSet FOLLOW_statement_in_block501 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_TSTOP_in_block503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_getExpr_in_statement516 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setExpr_in_statement521 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_getExpr532 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_getExpr535 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_getExpr554 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_getExpr557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_getExpr571 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_ILITERAL_in_getExpr574 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_in_setExpr593 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_ID_in_setExpr596 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_setExpr598 = new BitSet(new ulong[]{0x0001A00000003000UL});
    public static readonly BitSet FOLLOW_set_in_setExpr600 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}