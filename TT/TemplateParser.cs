// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 TT\\Template.g 2009-06-11 21:44:37

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
		"SET", 
		"PRINT", 
		"DOCUMENT", 
		"WS", 
		"TSTART", 
		"TSTOP", 
		"QUOTE", 
		"SQUOTE", 
		"ILITERAL", 
		"LITERAL", 
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
		"END", 
		"ID", 
		"NUMBER", 
		"DECIMAL", 
		"ADD", 
		"SUB", 
		"MULT", 
		"DIV", 
		"ASSIGN", 
		"EQUAL", 
		"CHAR", 
		"'GET'", 
		"'SET'"
    };

    public const int WHILE = 23;
    public const int CASE = 29;
    public const int CHAR = 55;
    public const int RAWPERL = 34;
    public const int SUB = 50;
    public const int ID = 46;
    public const int EOF = -1;
    public const int TSTART = 9;
    public const int IF = 24;
    public const int T__56 = 56;
    public const int QUOTE = 11;
    public const int TSTOP = 10;
    public const int T__57 = 57;
    public const int FINAL = 38;
    public const int COMMENTS = 44;
    public const int INSERT = 17;
    public const int DOCUMENT = 7;
    public const int EQUAL = 54;
    public const int INCLUDE = 19;
    public const int RETURN = 41;
    public const int GET = 4;
    public const int NEXT = 39;
    public const int LAST = 40;
    public const int UNLESS = 25;
    public const int ILITERAL = 13;
    public const int ADD = 49;
    public const int SWITCH = 28;
    public const int DEFAULT = 16;
    public const int ELSE = 27;
    public const int NUMBER = 47;
    public const int TAGS = 43;
    public const int STOP = 42;
    public const int LITERAL = 14;
    public const int SET = 5;
    public const int MULT = 51;
    public const int SQUOTE = 12;
    public const int WRAPPER = 20;
    public const int PRINT = 6;
    public const int TRY = 35;
    public const int PERL = 33;
    public const int WS = 8;
    public const int DECIMAL = 48;
    public const int BLOCK = 21;
    public const int ASSIGN = 53;
    public const int FILTER = 31;
    public const int FOREACH = 22;
    public const int CALL = 15;
    public const int ELSIF = 26;
    public const int USE = 32;
    public const int DIV = 52;
    public const int END = 45;
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
            			    	PushFollow(FOLLOW_block_in_document478);
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

            	TSTART2=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_block499); 
            	PushFollow(FOLLOW_statement_in_block502);
            	statement3 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement3.Tree);
            	TSTOP4=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_block504); 

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
    // TT\\Template.g:81:1: statement : ( getExpr | setExpr | defaultExpr | ifStatement );
    public TemplateParser.statement_return statement() // throws RecognitionException [1]
    {   
        TemplateParser.statement_return retval = new TemplateParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.getExpr_return getExpr5 = default(TemplateParser.getExpr_return);

        TemplateParser.setExpr_return setExpr6 = default(TemplateParser.setExpr_return);

        TemplateParser.defaultExpr_return defaultExpr7 = default(TemplateParser.defaultExpr_return);

        TemplateParser.ifStatement_return ifStatement8 = default(TemplateParser.ifStatement_return);



        try 
    	{
            // TT\\Template.g:82:2: ( getExpr | setExpr | defaultExpr | ifStatement )
            int alt2 = 4;
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
                else if ( ((LA2_2 >= TSTART && LA2_2 <= TSTOP) || LA2_2 == END) )
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
            case 57:
            	{
                alt2 = 2;
                }
                break;
            case DEFAULT:
            	{
                alt2 = 3;
                }
                break;
            case IF:
            	{
                alt2 = 4;
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

                    	PushFollow(FOLLOW_getExpr_in_statement517);
                    	getExpr5 = getExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, getExpr5.Tree);

                    }
                    break;
                case 2 :
                    // TT\\Template.g:83:4: setExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_setExpr_in_statement522);
                    	setExpr6 = setExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, setExpr6.Tree);

                    }
                    break;
                case 3 :
                    // TT\\Template.g:84:4: defaultExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defaultExpr_in_statement527);
                    	defaultExpr7 = defaultExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, defaultExpr7.Tree);

                    }
                    break;
                case 4 :
                    // TT\\Template.g:85:4: ifStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement532);
                    	ifStatement8 = ifStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifStatement8.Tree);

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

    public class ifStatement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "ifStatement"
    // TT\\Template.g:88:1: ifStatement : IF ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END -> ^( IF ID statement ) ;
    public TemplateParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        TemplateParser.ifStatement_return retval = new TemplateParser.ifStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IF9 = null;
        IToken ID10 = null;
        IToken TSTOP11 = null;
        IToken TSTART12 = null;
        IToken TSTOP14 = null;
        IToken TSTART15 = null;
        IToken END16 = null;
        TemplateParser.statement_return statement13 = default(TemplateParser.statement_return);


        CommonTree IF9_tree=null;
        CommonTree ID10_tree=null;
        CommonTree TSTOP11_tree=null;
        CommonTree TSTART12_tree=null;
        CommonTree TSTOP14_tree=null;
        CommonTree TSTART15_tree=null;
        CommonTree END16_tree=null;
        RewriteRuleTokenStream stream_TSTOP = new RewriteRuleTokenStream(adaptor,"token TSTOP");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_TSTART = new RewriteRuleTokenStream(adaptor,"token TSTART");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // TT\\Template.g:89:2: ( IF ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END -> ^( IF ID statement ) )
            // TT\\Template.g:89:4: IF ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END
            {
            	IF9=(IToken)Match(input,IF,FOLLOW_IF_in_ifStatement543);  
            	stream_IF.Add(IF9);

            	ID10=(IToken)Match(input,ID,FOLLOW_ID_in_ifStatement545);  
            	stream_ID.Add(ID10);

            	// TT\\Template.g:89:10: ( TSTOP )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == TSTOP) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // TT\\Template.g:89:10: TSTOP
            	        {
            	        	TSTOP11=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_ifStatement547);  
            	        	stream_TSTOP.Add(TSTOP11);


            	        }
            	        break;

            	}

            	// TT\\Template.g:89:17: ( TSTART )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == TSTART) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // TT\\Template.g:89:17: TSTART
            	        {
            	        	TSTART12=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_ifStatement550);  
            	        	stream_TSTART.Add(TSTART12);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_statement_in_ifStatement553);
            	statement13 = statement();
            	state.followingStackPointer--;

            	stream_statement.Add(statement13.Tree);
            	// TT\\Template.g:89:35: ( TSTOP )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == TSTOP) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // TT\\Template.g:89:35: TSTOP
            	        {
            	        	TSTOP14=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_ifStatement555);  
            	        	stream_TSTOP.Add(TSTOP14);


            	        }
            	        break;

            	}

            	// TT\\Template.g:89:42: ( TSTART )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == TSTART) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // TT\\Template.g:89:42: TSTART
            	        {
            	        	TSTART15=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_ifStatement558);  
            	        	stream_TSTART.Add(TSTART15);


            	        }
            	        break;

            	}

            	END16=(IToken)Match(input,END,FOLLOW_END_in_ifStatement561);  
            	stream_END.Add(END16);



            	// AST REWRITE
            	// elements:          statement, ID, IF
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 89:54: -> ^( IF ID statement )
            	{
            	    // TT\\Template.g:89:57: ^( IF ID statement )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
            	    adaptor.AddChild(root_1, stream_statement.NextTree());

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
    // $ANTLR end "ifStatement"

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
    // TT\\Template.g:92:1: getExpr : ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) );
    public TemplateParser.getExpr_return getExpr() // throws RecognitionException [1]
    {   
        TemplateParser.getExpr_return retval = new TemplateParser.getExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal17 = null;
        IToken ID18 = null;
        IToken string_literal19 = null;
        IToken LITERAL20 = null;
        IToken string_literal21 = null;
        IToken ILITERAL22 = null;

        CommonTree string_literal17_tree=null;
        CommonTree ID18_tree=null;
        CommonTree string_literal19_tree=null;
        CommonTree LITERAL20_tree=null;
        CommonTree string_literal21_tree=null;
        CommonTree ILITERAL22_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ILITERAL = new RewriteRuleTokenStream(adaptor,"token ILITERAL");

        try 
    	{
            // TT\\Template.g:93:2: ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) )
            int alt10 = 3;
            switch ( input.LA(1) ) 
            {
            case 56:
            	{
                switch ( input.LA(2) ) 
                {
                case LITERAL:
                	{
                    alt10 = 2;
                    }
                    break;
                case ILITERAL:
                	{
                    alt10 = 3;
                    }
                    break;
                case ID:
                	{
                    alt10 = 1;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d10s1 =
                	        new NoViableAltException("", 10, 1, input);

                	    throw nvae_d10s1;
                }

                }
                break;
            case ID:
            	{
                alt10 = 1;
                }
                break;
            case LITERAL:
            	{
                alt10 = 2;
                }
                break;
            case ILITERAL:
            	{
                alt10 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // TT\\Template.g:93:4: ( 'GET' )? ID
                    {
                    	// TT\\Template.g:93:4: ( 'GET' )?
                    	int alt7 = 2;
                    	int LA7_0 = input.LA(1);

                    	if ( (LA7_0 == 56) )
                    	{
                    	    alt7 = 1;
                    	}
                    	switch (alt7) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:93:4: 'GET'
                    	        {
                    	        	string_literal17=(IToken)Match(input,56,FOLLOW_56_in_getExpr582);  
                    	        	stream_56.Add(string_literal17);


                    	        }
                    	        break;

                    	}

                    	ID18=(IToken)Match(input,ID,FOLLOW_ID_in_getExpr585);  
                    	stream_ID.Add(ID18);



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
                    	// 93:20: -> ^( GET ID )
                    	{
                    	    // TT\\Template.g:93:23: ^( GET ID )
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
                    // TT\\Template.g:94:4: ( 'GET' )? LITERAL
                    {
                    	// TT\\Template.g:94:4: ( 'GET' )?
                    	int alt8 = 2;
                    	int LA8_0 = input.LA(1);

                    	if ( (LA8_0 == 56) )
                    	{
                    	    alt8 = 1;
                    	}
                    	switch (alt8) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:94:4: 'GET'
                    	        {
                    	        	string_literal19=(IToken)Match(input,56,FOLLOW_56_in_getExpr604);  
                    	        	stream_56.Add(string_literal19);


                    	        }
                    	        break;

                    	}

                    	LITERAL20=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_getExpr607);  
                    	stream_LITERAL.Add(LITERAL20);



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
                    	// 94:20: -> ^( GET LITERAL )
                    	{
                    	    // TT\\Template.g:94:23: ^( GET LITERAL )
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
                    // TT\\Template.g:95:4: ( 'GET' )? ILITERAL
                    {
                    	// TT\\Template.g:95:4: ( 'GET' )?
                    	int alt9 = 2;
                    	int LA9_0 = input.LA(1);

                    	if ( (LA9_0 == 56) )
                    	{
                    	    alt9 = 1;
                    	}
                    	switch (alt9) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:95:4: 'GET'
                    	        {
                    	        	string_literal21=(IToken)Match(input,56,FOLLOW_56_in_getExpr621);  
                    	        	stream_56.Add(string_literal21);


                    	        }
                    	        break;

                    	}

                    	ILITERAL22=(IToken)Match(input,ILITERAL,FOLLOW_ILITERAL_in_getExpr624);  
                    	stream_ILITERAL.Add(ILITERAL22);



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
                    	// 95:20: -> ^( GET ILITERAL )
                    	{
                    	    // TT\\Template.g:95:23: ^( GET ILITERAL )
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
    // TT\\Template.g:98:1: setExpr : ( 'SET' )? ( assignment )+ -> ( ^( SET assignment ) )+ ;
    public TemplateParser.setExpr_return setExpr() // throws RecognitionException [1]
    {   
        TemplateParser.setExpr_return retval = new TemplateParser.setExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal23 = null;
        TemplateParser.assignment_return assignment24 = default(TemplateParser.assignment_return);


        CommonTree string_literal23_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_assignment = new RewriteRuleSubtreeStream(adaptor,"rule assignment");
        try 
    	{
            // TT\\Template.g:99:2: ( ( 'SET' )? ( assignment )+ -> ( ^( SET assignment ) )+ )
            // TT\\Template.g:99:4: ( 'SET' )? ( assignment )+
            {
            	// TT\\Template.g:99:4: ( 'SET' )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 57) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // TT\\Template.g:99:4: 'SET'
            	        {
            	        	string_literal23=(IToken)Match(input,57,FOLLOW_57_in_setExpr643);  
            	        	stream_57.Add(string_literal23);


            	        }
            	        break;

            	}

            	// TT\\Template.g:99:11: ( assignment )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == ID) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // TT\\Template.g:99:12: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_setExpr647);
            			    	assignment24 = assignment();
            			    	state.followingStackPointer--;

            			    	stream_assignment.Add(assignment24.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt12 >= 1 ) goto loop12;
            		            EarlyExitException eee12 =
            		                new EarlyExitException(12, input);
            		            throw eee12;
            	    }
            	    cnt12++;
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements



            	// AST REWRITE
            	// elements:          assignment
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 99:25: -> ( ^( SET assignment ) )+
            	{
            	    if ( !(stream_assignment.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_assignment.HasNext() )
            	    {
            	        // TT\\Template.g:99:28: ^( SET assignment )
            	        {
            	        CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(SET, "SET"), root_1);

            	        adaptor.AddChild(root_1, stream_assignment.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_assignment.Reset();

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
    // $ANTLR end "setExpr"

    public class defaultExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "defaultExpr"
    // TT\\Template.g:102:1: defaultExpr : DEFAULT ( assignment )+ -> ( ^( DEFAULT assignment ) )+ ;
    public TemplateParser.defaultExpr_return defaultExpr() // throws RecognitionException [1]
    {   
        TemplateParser.defaultExpr_return retval = new TemplateParser.defaultExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DEFAULT25 = null;
        TemplateParser.assignment_return assignment26 = default(TemplateParser.assignment_return);


        CommonTree DEFAULT25_tree=null;
        RewriteRuleTokenStream stream_DEFAULT = new RewriteRuleTokenStream(adaptor,"token DEFAULT");
        RewriteRuleSubtreeStream stream_assignment = new RewriteRuleSubtreeStream(adaptor,"rule assignment");
        try 
    	{
            // TT\\Template.g:103:2: ( DEFAULT ( assignment )+ -> ( ^( DEFAULT assignment ) )+ )
            // TT\\Template.g:103:4: DEFAULT ( assignment )+
            {
            	DEFAULT25=(IToken)Match(input,DEFAULT,FOLLOW_DEFAULT_in_defaultExpr669);  
            	stream_DEFAULT.Add(DEFAULT25);

            	// TT\\Template.g:103:12: ( assignment )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == ID) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // TT\\Template.g:103:13: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_defaultExpr672);
            			    	assignment26 = assignment();
            			    	state.followingStackPointer--;

            			    	stream_assignment.Add(assignment26.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt13 >= 1 ) goto loop13;
            		            EarlyExitException eee13 =
            		                new EarlyExitException(13, input);
            		            throw eee13;
            	    }
            	    cnt13++;
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements



            	// AST REWRITE
            	// elements:          DEFAULT, assignment
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 103:26: -> ( ^( DEFAULT assignment ) )+
            	{
            	    if ( !(stream_DEFAULT.HasNext() || stream_assignment.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_DEFAULT.HasNext() || stream_assignment.HasNext() )
            	    {
            	        // TT\\Template.g:103:29: ^( DEFAULT assignment )
            	        {
            	        CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	        root_1 = (CommonTree)adaptor.BecomeRoot(stream_DEFAULT.NextNode(), root_1);

            	        adaptor.AddChild(root_1, stream_assignment.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_DEFAULT.Reset();
            	    stream_assignment.Reset();

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
    // $ANTLR end "defaultExpr"

    public class assignment_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignment"
    // TT\\Template.g:106:1: assignment : ( ID ASSIGN LITERAL -> ID LITERAL | ID ASSIGN NUMBER -> ID NUMBER | ID ASSIGN DECIMAL -> ID DECIMAL );
    public TemplateParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        TemplateParser.assignment_return retval = new TemplateParser.assignment_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID27 = null;
        IToken ASSIGN28 = null;
        IToken LITERAL29 = null;
        IToken ID30 = null;
        IToken ASSIGN31 = null;
        IToken NUMBER32 = null;
        IToken ID33 = null;
        IToken ASSIGN34 = null;
        IToken DECIMAL35 = null;

        CommonTree ID27_tree=null;
        CommonTree ASSIGN28_tree=null;
        CommonTree LITERAL29_tree=null;
        CommonTree ID30_tree=null;
        CommonTree ASSIGN31_tree=null;
        CommonTree NUMBER32_tree=null;
        CommonTree ID33_tree=null;
        CommonTree ASSIGN34_tree=null;
        CommonTree DECIMAL35_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_DECIMAL = new RewriteRuleTokenStream(adaptor,"token DECIMAL");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");

        try 
    	{
            // TT\\Template.g:107:2: ( ID ASSIGN LITERAL -> ID LITERAL | ID ASSIGN NUMBER -> ID NUMBER | ID ASSIGN DECIMAL -> ID DECIMAL )
            int alt14 = 3;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == ID) )
            {
                int LA14_1 = input.LA(2);

                if ( (LA14_1 == ASSIGN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case LITERAL:
                    	{
                        alt14 = 1;
                        }
                        break;
                    case NUMBER:
                    	{
                        alt14 = 2;
                        }
                        break;
                    case DECIMAL:
                    	{
                        alt14 = 3;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d14s2 =
                    	        new NoViableAltException("", 14, 2, input);

                    	    throw nvae_d14s2;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d14s1 =
                        new NoViableAltException("", 14, 1, input);

                    throw nvae_d14s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // TT\\Template.g:107:4: ID ASSIGN LITERAL
                    {
                    	ID27=(IToken)Match(input,ID,FOLLOW_ID_in_assignment694);  
                    	stream_ID.Add(ID27);

                    	ASSIGN28=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment696);  
                    	stream_ASSIGN.Add(ASSIGN28);

                    	LITERAL29=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_assignment698);  
                    	stream_LITERAL.Add(LITERAL29);



                    	// AST REWRITE
                    	// elements:          ID, LITERAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 107:22: -> ID LITERAL
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_LITERAL.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // TT\\Template.g:108:4: ID ASSIGN NUMBER
                    {
                    	ID30=(IToken)Match(input,ID,FOLLOW_ID_in_assignment709);  
                    	stream_ID.Add(ID30);

                    	ASSIGN31=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment711);  
                    	stream_ASSIGN.Add(ASSIGN31);

                    	NUMBER32=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_assignment713);  
                    	stream_NUMBER.Add(NUMBER32);



                    	// AST REWRITE
                    	// elements:          NUMBER, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 108:22: -> ID NUMBER
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_NUMBER.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // TT\\Template.g:109:4: ID ASSIGN DECIMAL
                    {
                    	ID33=(IToken)Match(input,ID,FOLLOW_ID_in_assignment725);  
                    	stream_ID.Add(ID33);

                    	ASSIGN34=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment727);  
                    	stream_ASSIGN.Add(ASSIGN34);

                    	DECIMAL35=(IToken)Match(input,DECIMAL,FOLLOW_DECIMAL_in_assignment729);  
                    	stream_DECIMAL.Add(DECIMAL35);



                    	// AST REWRITE
                    	// elements:          ID, DECIMAL
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 109:22: -> ID DECIMAL
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_DECIMAL.NextNode());

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
    // $ANTLR end "assignment"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_block_in_document478 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_TSTART_in_block499 = new BitSet(new ulong[]{0x0300400001016000UL});
    public static readonly BitSet FOLLOW_statement_in_block502 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_TSTOP_in_block504 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_getExpr_in_statement517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setExpr_in_statement522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defaultExpr_in_statement527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement543 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_ifStatement545 = new BitSet(new ulong[]{0x0300400001016600UL});
    public static readonly BitSet FOLLOW_TSTOP_in_ifStatement547 = new BitSet(new ulong[]{0x0300400001016200UL});
    public static readonly BitSet FOLLOW_TSTART_in_ifStatement550 = new BitSet(new ulong[]{0x0300400001016000UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement553 = new BitSet(new ulong[]{0x0000200000000600UL});
    public static readonly BitSet FOLLOW_TSTOP_in_ifStatement555 = new BitSet(new ulong[]{0x0000200000000200UL});
    public static readonly BitSet FOLLOW_TSTART_in_ifStatement558 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_END_in_ifStatement561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_getExpr582 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_ID_in_getExpr585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_getExpr604 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_getExpr607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_getExpr621 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_ILITERAL_in_getExpr624 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_setExpr643 = new BitSet(new ulong[]{0x0200400000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_setExpr647 = new BitSet(new ulong[]{0x0200400000000002UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_defaultExpr669 = new BitSet(new ulong[]{0x0200400000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_defaultExpr672 = new BitSet(new ulong[]{0x0200400000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment694 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment696 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_assignment698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment709 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment711 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_assignment713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment725 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment727 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_DECIMAL_in_assignment729 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}