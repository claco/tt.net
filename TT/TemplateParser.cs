// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 TT\\Template.g 2009-06-12 20:20:15

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
		"IN", 
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
    public const int CHAR = 56;
    public const int RAWPERL = 34;
    public const int SUB = 51;
    public const int ID = 47;
    public const int EOF = -1;
    public const int TSTART = 9;
    public const int IF = 24;
    public const int QUOTE = 11;
    public const int TSTOP = 10;
    public const int T__57 = 57;
    public const int FINAL = 38;
    public const int T__58 = 58;
    public const int IN = 46;
    public const int COMMENTS = 44;
    public const int INSERT = 17;
    public const int DOCUMENT = 7;
    public const int EQUAL = 55;
    public const int INCLUDE = 19;
    public const int RETURN = 41;
    public const int GET = 4;
    public const int NEXT = 39;
    public const int LAST = 40;
    public const int UNLESS = 25;
    public const int ILITERAL = 13;
    public const int ADD = 50;
    public const int SWITCH = 28;
    public const int DEFAULT = 16;
    public const int ELSE = 27;
    public const int NUMBER = 48;
    public const int TAGS = 43;
    public const int STOP = 42;
    public const int LITERAL = 14;
    public const int SET = 5;
    public const int MULT = 52;
    public const int SQUOTE = 12;
    public const int WRAPPER = 20;
    public const int PRINT = 6;
    public const int TRY = 35;
    public const int PERL = 33;
    public const int WS = 8;
    public const int DECIMAL = 49;
    public const int BLOCK = 21;
    public const int ASSIGN = 54;
    public const int FILTER = 31;
    public const int FOREACH = 22;
    public const int CALL = 15;
    public const int ELSIF = 26;
    public const int USE = 32;
    public const int DIV = 53;
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
    // TT\\Template.g:74:1: document : ( block )* -> ^( DOCUMENT ( block )* ) ;
    public TemplateParser.document_return document() // throws RecognitionException [1]
    {   
        TemplateParser.document_return retval = new TemplateParser.document_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.block_return block1 = default(TemplateParser.block_return);


        RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor,"rule block");
        try 
    	{
            // TT\\Template.g:75:2: ( ( block )* -> ^( DOCUMENT ( block )* ) )
            // TT\\Template.g:75:4: ( block )*
            {
            	// TT\\Template.g:75:4: ( block )*
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
            			    // TT\\Template.g:75:4: block
            			    {
            			    	PushFollow(FOLLOW_block_in_document485);
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
            	// 75:11: -> ^( DOCUMENT ( block )* )
            	{
            	    // TT\\Template.g:75:14: ^( DOCUMENT ( block )* )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(DOCUMENT, "DOCUMENT"), root_1);

            	    // TT\\Template.g:75:25: ( block )*
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
    // TT\\Template.g:78:1: block : TSTART statement TSTOP ;
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
            // TT\\Template.g:79:2: ( TSTART statement TSTOP )
            // TT\\Template.g:79:4: TSTART statement TSTOP
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	TSTART2=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_block506); 
            	PushFollow(FOLLOW_statement_in_block509);
            	statement3 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement3.Tree);
            	TSTOP4=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_block511); 

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
    // TT\\Template.g:82:1: statement : ( getExpr | setExpr | defaultExpr | ifStatement | forEachLoop );
    public TemplateParser.statement_return statement() // throws RecognitionException [1]
    {   
        TemplateParser.statement_return retval = new TemplateParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        TemplateParser.getExpr_return getExpr5 = default(TemplateParser.getExpr_return);

        TemplateParser.setExpr_return setExpr6 = default(TemplateParser.setExpr_return);

        TemplateParser.defaultExpr_return defaultExpr7 = default(TemplateParser.defaultExpr_return);

        TemplateParser.ifStatement_return ifStatement8 = default(TemplateParser.ifStatement_return);

        TemplateParser.forEachLoop_return forEachLoop9 = default(TemplateParser.forEachLoop_return);



        try 
    	{
            // TT\\Template.g:83:2: ( getExpr | setExpr | defaultExpr | ifStatement | forEachLoop )
            int alt2 = 5;
            switch ( input.LA(1) ) 
            {
            case ILITERAL:
            case LITERAL:
            case 57:
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
            case 58:
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
            case FOREACH:
            	{
                alt2 = 5;
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
                    // TT\\Template.g:83:4: getExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_getExpr_in_statement524);
                    	getExpr5 = getExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, getExpr5.Tree);

                    }
                    break;
                case 2 :
                    // TT\\Template.g:84:4: setExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_setExpr_in_statement529);
                    	setExpr6 = setExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, setExpr6.Tree);

                    }
                    break;
                case 3 :
                    // TT\\Template.g:85:4: defaultExpr
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defaultExpr_in_statement534);
                    	defaultExpr7 = defaultExpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, defaultExpr7.Tree);

                    }
                    break;
                case 4 :
                    // TT\\Template.g:86:4: ifStatement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement539);
                    	ifStatement8 = ifStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifStatement8.Tree);

                    }
                    break;
                case 5 :
                    // TT\\Template.g:87:4: forEachLoop
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forEachLoop_in_statement544);
                    	forEachLoop9 = forEachLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, forEachLoop9.Tree);

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
    // TT\\Template.g:90:1: ifStatement : IF ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END -> ^( IF ID statement ) ;
    public TemplateParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        TemplateParser.ifStatement_return retval = new TemplateParser.ifStatement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IF10 = null;
        IToken ID11 = null;
        IToken TSTOP12 = null;
        IToken TSTART13 = null;
        IToken TSTOP15 = null;
        IToken TSTART16 = null;
        IToken END17 = null;
        TemplateParser.statement_return statement14 = default(TemplateParser.statement_return);


        CommonTree IF10_tree=null;
        CommonTree ID11_tree=null;
        CommonTree TSTOP12_tree=null;
        CommonTree TSTART13_tree=null;
        CommonTree TSTOP15_tree=null;
        CommonTree TSTART16_tree=null;
        CommonTree END17_tree=null;
        RewriteRuleTokenStream stream_TSTOP = new RewriteRuleTokenStream(adaptor,"token TSTOP");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_IF = new RewriteRuleTokenStream(adaptor,"token IF");
        RewriteRuleTokenStream stream_TSTART = new RewriteRuleTokenStream(adaptor,"token TSTART");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // TT\\Template.g:91:2: ( IF ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END -> ^( IF ID statement ) )
            // TT\\Template.g:91:4: IF ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END
            {
            	IF10=(IToken)Match(input,IF,FOLLOW_IF_in_ifStatement555);  
            	stream_IF.Add(IF10);

            	ID11=(IToken)Match(input,ID,FOLLOW_ID_in_ifStatement557);  
            	stream_ID.Add(ID11);

            	// TT\\Template.g:91:10: ( TSTOP )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == TSTOP) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // TT\\Template.g:91:10: TSTOP
            	        {
            	        	TSTOP12=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_ifStatement559);  
            	        	stream_TSTOP.Add(TSTOP12);


            	        }
            	        break;

            	}

            	// TT\\Template.g:91:17: ( TSTART )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == TSTART) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // TT\\Template.g:91:17: TSTART
            	        {
            	        	TSTART13=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_ifStatement562);  
            	        	stream_TSTART.Add(TSTART13);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_statement_in_ifStatement565);
            	statement14 = statement();
            	state.followingStackPointer--;

            	stream_statement.Add(statement14.Tree);
            	// TT\\Template.g:91:35: ( TSTOP )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == TSTOP) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // TT\\Template.g:91:35: TSTOP
            	        {
            	        	TSTOP15=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_ifStatement567);  
            	        	stream_TSTOP.Add(TSTOP15);


            	        }
            	        break;

            	}

            	// TT\\Template.g:91:42: ( TSTART )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == TSTART) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // TT\\Template.g:91:42: TSTART
            	        {
            	        	TSTART16=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_ifStatement570);  
            	        	stream_TSTART.Add(TSTART16);


            	        }
            	        break;

            	}

            	END17=(IToken)Match(input,END,FOLLOW_END_in_ifStatement573);  
            	stream_END.Add(END17);



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
            	// 91:54: -> ^( IF ID statement )
            	{
            	    // TT\\Template.g:91:57: ^( IF ID statement )
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

    public class forEachLoop_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "forEachLoop"
    // TT\\Template.g:94:1: forEachLoop : FOREACH ID IN ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END -> ^( FOREACH ID ID statement ) ;
    public TemplateParser.forEachLoop_return forEachLoop() // throws RecognitionException [1]
    {   
        TemplateParser.forEachLoop_return retval = new TemplateParser.forEachLoop_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken FOREACH18 = null;
        IToken ID19 = null;
        IToken IN20 = null;
        IToken ID21 = null;
        IToken TSTOP22 = null;
        IToken TSTART23 = null;
        IToken TSTOP25 = null;
        IToken TSTART26 = null;
        IToken END27 = null;
        TemplateParser.statement_return statement24 = default(TemplateParser.statement_return);


        CommonTree FOREACH18_tree=null;
        CommonTree ID19_tree=null;
        CommonTree IN20_tree=null;
        CommonTree ID21_tree=null;
        CommonTree TSTOP22_tree=null;
        CommonTree TSTART23_tree=null;
        CommonTree TSTOP25_tree=null;
        CommonTree TSTART26_tree=null;
        CommonTree END27_tree=null;
        RewriteRuleTokenStream stream_TSTOP = new RewriteRuleTokenStream(adaptor,"token TSTOP");
        RewriteRuleTokenStream stream_FOREACH = new RewriteRuleTokenStream(adaptor,"token FOREACH");
        RewriteRuleTokenStream stream_IN = new RewriteRuleTokenStream(adaptor,"token IN");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_TSTART = new RewriteRuleTokenStream(adaptor,"token TSTART");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // TT\\Template.g:95:2: ( FOREACH ID IN ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END -> ^( FOREACH ID ID statement ) )
            // TT\\Template.g:95:4: FOREACH ID IN ID ( TSTOP )? ( TSTART )? statement ( TSTOP )? ( TSTART )? END
            {
            	FOREACH18=(IToken)Match(input,FOREACH,FOLLOW_FOREACH_in_forEachLoop594);  
            	stream_FOREACH.Add(FOREACH18);

            	ID19=(IToken)Match(input,ID,FOLLOW_ID_in_forEachLoop596);  
            	stream_ID.Add(ID19);

            	IN20=(IToken)Match(input,IN,FOLLOW_IN_in_forEachLoop598);  
            	stream_IN.Add(IN20);

            	ID21=(IToken)Match(input,ID,FOLLOW_ID_in_forEachLoop600);  
            	stream_ID.Add(ID21);

            	// TT\\Template.g:95:21: ( TSTOP )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == TSTOP) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // TT\\Template.g:95:21: TSTOP
            	        {
            	        	TSTOP22=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_forEachLoop602);  
            	        	stream_TSTOP.Add(TSTOP22);


            	        }
            	        break;

            	}

            	// TT\\Template.g:95:28: ( TSTART )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == TSTART) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // TT\\Template.g:95:28: TSTART
            	        {
            	        	TSTART23=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_forEachLoop605);  
            	        	stream_TSTART.Add(TSTART23);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_statement_in_forEachLoop608);
            	statement24 = statement();
            	state.followingStackPointer--;

            	stream_statement.Add(statement24.Tree);
            	// TT\\Template.g:95:46: ( TSTOP )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == TSTOP) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // TT\\Template.g:95:46: TSTOP
            	        {
            	        	TSTOP25=(IToken)Match(input,TSTOP,FOLLOW_TSTOP_in_forEachLoop610);  
            	        	stream_TSTOP.Add(TSTOP25);


            	        }
            	        break;

            	}

            	// TT\\Template.g:95:53: ( TSTART )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == TSTART) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // TT\\Template.g:95:53: TSTART
            	        {
            	        	TSTART26=(IToken)Match(input,TSTART,FOLLOW_TSTART_in_forEachLoop613);  
            	        	stream_TSTART.Add(TSTART26);


            	        }
            	        break;

            	}

            	END27=(IToken)Match(input,END,FOLLOW_END_in_forEachLoop616);  
            	stream_END.Add(END27);



            	// AST REWRITE
            	// elements:          ID, statement, ID, FOREACH
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 95:65: -> ^( FOREACH ID ID statement )
            	{
            	    // TT\\Template.g:95:68: ^( FOREACH ID ID statement )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_FOREACH.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ID.NextNode());
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
    // $ANTLR end "forEachLoop"

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
    // TT\\Template.g:98:1: getExpr : ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) );
    public TemplateParser.getExpr_return getExpr() // throws RecognitionException [1]
    {   
        TemplateParser.getExpr_return retval = new TemplateParser.getExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal28 = null;
        IToken ID29 = null;
        IToken string_literal30 = null;
        IToken LITERAL31 = null;
        IToken string_literal32 = null;
        IToken ILITERAL33 = null;

        CommonTree string_literal28_tree=null;
        CommonTree ID29_tree=null;
        CommonTree string_literal30_tree=null;
        CommonTree LITERAL31_tree=null;
        CommonTree string_literal32_tree=null;
        CommonTree ILITERAL33_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_ILITERAL = new RewriteRuleTokenStream(adaptor,"token ILITERAL");

        try 
    	{
            // TT\\Template.g:99:2: ( ( 'GET' )? ID -> ^( GET ID ) | ( 'GET' )? LITERAL -> ^( GET LITERAL ) | ( 'GET' )? ILITERAL -> ^( GET ILITERAL ) )
            int alt14 = 3;
            switch ( input.LA(1) ) 
            {
            case 57:
            	{
                switch ( input.LA(2) ) 
                {
                case ID:
                	{
                    alt14 = 1;
                    }
                    break;
                case ILITERAL:
                	{
                    alt14 = 3;
                    }
                    break;
                case LITERAL:
                	{
                    alt14 = 2;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d14s1 =
                	        new NoViableAltException("", 14, 1, input);

                	    throw nvae_d14s1;
                }

                }
                break;
            case ID:
            	{
                alt14 = 1;
                }
                break;
            case LITERAL:
            	{
                alt14 = 2;
                }
                break;
            case ILITERAL:
            	{
                alt14 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            }

            switch (alt14) 
            {
                case 1 :
                    // TT\\Template.g:99:4: ( 'GET' )? ID
                    {
                    	// TT\\Template.g:99:4: ( 'GET' )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == 57) )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:99:4: 'GET'
                    	        {
                    	        	string_literal28=(IToken)Match(input,57,FOLLOW_57_in_getExpr639);  
                    	        	stream_57.Add(string_literal28);


                    	        }
                    	        break;

                    	}

                    	ID29=(IToken)Match(input,ID,FOLLOW_ID_in_getExpr642);  
                    	stream_ID.Add(ID29);



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
                    	// 99:20: -> ^( GET ID )
                    	{
                    	    // TT\\Template.g:99:23: ^( GET ID )
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
                    // TT\\Template.g:100:4: ( 'GET' )? LITERAL
                    {
                    	// TT\\Template.g:100:4: ( 'GET' )?
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == 57) )
                    	{
                    	    alt12 = 1;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:100:4: 'GET'
                    	        {
                    	        	string_literal30=(IToken)Match(input,57,FOLLOW_57_in_getExpr661);  
                    	        	stream_57.Add(string_literal30);


                    	        }
                    	        break;

                    	}

                    	LITERAL31=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_getExpr664);  
                    	stream_LITERAL.Add(LITERAL31);



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
                    	// 100:20: -> ^( GET LITERAL )
                    	{
                    	    // TT\\Template.g:100:23: ^( GET LITERAL )
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
                    // TT\\Template.g:101:4: ( 'GET' )? ILITERAL
                    {
                    	// TT\\Template.g:101:4: ( 'GET' )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == 57) )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // TT\\Template.g:101:4: 'GET'
                    	        {
                    	        	string_literal32=(IToken)Match(input,57,FOLLOW_57_in_getExpr678);  
                    	        	stream_57.Add(string_literal32);


                    	        }
                    	        break;

                    	}

                    	ILITERAL33=(IToken)Match(input,ILITERAL,FOLLOW_ILITERAL_in_getExpr681);  
                    	stream_ILITERAL.Add(ILITERAL33);



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
                    	// 101:20: -> ^( GET ILITERAL )
                    	{
                    	    // TT\\Template.g:101:23: ^( GET ILITERAL )
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
    // TT\\Template.g:104:1: setExpr : ( 'SET' )? ( assignment )+ -> ( ^( SET assignment ) )+ ;
    public TemplateParser.setExpr_return setExpr() // throws RecognitionException [1]
    {   
        TemplateParser.setExpr_return retval = new TemplateParser.setExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal34 = null;
        TemplateParser.assignment_return assignment35 = default(TemplateParser.assignment_return);


        CommonTree string_literal34_tree=null;
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleSubtreeStream stream_assignment = new RewriteRuleSubtreeStream(adaptor,"rule assignment");
        try 
    	{
            // TT\\Template.g:105:2: ( ( 'SET' )? ( assignment )+ -> ( ^( SET assignment ) )+ )
            // TT\\Template.g:105:4: ( 'SET' )? ( assignment )+
            {
            	// TT\\Template.g:105:4: ( 'SET' )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 58) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // TT\\Template.g:105:4: 'SET'
            	        {
            	        	string_literal34=(IToken)Match(input,58,FOLLOW_58_in_setExpr700);  
            	        	stream_58.Add(string_literal34);


            	        }
            	        break;

            	}

            	// TT\\Template.g:105:11: ( assignment )+
            	int cnt16 = 0;
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == ID) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // TT\\Template.g:105:12: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_setExpr704);
            			    	assignment35 = assignment();
            			    	state.followingStackPointer--;

            			    	stream_assignment.Add(assignment35.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt16 >= 1 ) goto loop16;
            		            EarlyExitException eee16 =
            		                new EarlyExitException(16, input);
            		            throw eee16;
            	    }
            	    cnt16++;
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements



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
            	// 105:25: -> ( ^( SET assignment ) )+
            	{
            	    if ( !(stream_assignment.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_assignment.HasNext() )
            	    {
            	        // TT\\Template.g:105:28: ^( SET assignment )
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
    // TT\\Template.g:108:1: defaultExpr : DEFAULT ( assignment )+ -> ( ^( DEFAULT assignment ) )+ ;
    public TemplateParser.defaultExpr_return defaultExpr() // throws RecognitionException [1]
    {   
        TemplateParser.defaultExpr_return retval = new TemplateParser.defaultExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DEFAULT36 = null;
        TemplateParser.assignment_return assignment37 = default(TemplateParser.assignment_return);


        CommonTree DEFAULT36_tree=null;
        RewriteRuleTokenStream stream_DEFAULT = new RewriteRuleTokenStream(adaptor,"token DEFAULT");
        RewriteRuleSubtreeStream stream_assignment = new RewriteRuleSubtreeStream(adaptor,"rule assignment");
        try 
    	{
            // TT\\Template.g:109:2: ( DEFAULT ( assignment )+ -> ( ^( DEFAULT assignment ) )+ )
            // TT\\Template.g:109:4: DEFAULT ( assignment )+
            {
            	DEFAULT36=(IToken)Match(input,DEFAULT,FOLLOW_DEFAULT_in_defaultExpr726);  
            	stream_DEFAULT.Add(DEFAULT36);

            	// TT\\Template.g:109:12: ( assignment )+
            	int cnt17 = 0;
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == ID) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // TT\\Template.g:109:13: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_defaultExpr729);
            			    	assignment37 = assignment();
            			    	state.followingStackPointer--;

            			    	stream_assignment.Add(assignment37.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt17 >= 1 ) goto loop17;
            		            EarlyExitException eee17 =
            		                new EarlyExitException(17, input);
            		            throw eee17;
            	    }
            	    cnt17++;
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements



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
            	// 109:26: -> ( ^( DEFAULT assignment ) )+
            	{
            	    if ( !(stream_DEFAULT.HasNext() || stream_assignment.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_DEFAULT.HasNext() || stream_assignment.HasNext() )
            	    {
            	        // TT\\Template.g:109:29: ^( DEFAULT assignment )
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
    // TT\\Template.g:112:1: assignment : ( ID ASSIGN LITERAL -> ID LITERAL | ID ASSIGN NUMBER -> ID NUMBER | ID ASSIGN DECIMAL -> ID DECIMAL );
    public TemplateParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        TemplateParser.assignment_return retval = new TemplateParser.assignment_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID38 = null;
        IToken ASSIGN39 = null;
        IToken LITERAL40 = null;
        IToken ID41 = null;
        IToken ASSIGN42 = null;
        IToken NUMBER43 = null;
        IToken ID44 = null;
        IToken ASSIGN45 = null;
        IToken DECIMAL46 = null;

        CommonTree ID38_tree=null;
        CommonTree ASSIGN39_tree=null;
        CommonTree LITERAL40_tree=null;
        CommonTree ID41_tree=null;
        CommonTree ASSIGN42_tree=null;
        CommonTree NUMBER43_tree=null;
        CommonTree ID44_tree=null;
        CommonTree ASSIGN45_tree=null;
        CommonTree DECIMAL46_tree=null;
        RewriteRuleTokenStream stream_LITERAL = new RewriteRuleTokenStream(adaptor,"token LITERAL");
        RewriteRuleTokenStream stream_DECIMAL = new RewriteRuleTokenStream(adaptor,"token DECIMAL");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");
        RewriteRuleTokenStream stream_ASSIGN = new RewriteRuleTokenStream(adaptor,"token ASSIGN");

        try 
    	{
            // TT\\Template.g:113:2: ( ID ASSIGN LITERAL -> ID LITERAL | ID ASSIGN NUMBER -> ID NUMBER | ID ASSIGN DECIMAL -> ID DECIMAL )
            int alt18 = 3;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == ID) )
            {
                int LA18_1 = input.LA(2);

                if ( (LA18_1 == ASSIGN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case LITERAL:
                    	{
                        alt18 = 1;
                        }
                        break;
                    case NUMBER:
                    	{
                        alt18 = 2;
                        }
                        break;
                    case DECIMAL:
                    	{
                        alt18 = 3;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d18s2 =
                    	        new NoViableAltException("", 18, 2, input);

                    	    throw nvae_d18s2;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("", 18, 1, input);

                    throw nvae_d18s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // TT\\Template.g:113:4: ID ASSIGN LITERAL
                    {
                    	ID38=(IToken)Match(input,ID,FOLLOW_ID_in_assignment751);  
                    	stream_ID.Add(ID38);

                    	ASSIGN39=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment753);  
                    	stream_ASSIGN.Add(ASSIGN39);

                    	LITERAL40=(IToken)Match(input,LITERAL,FOLLOW_LITERAL_in_assignment755);  
                    	stream_LITERAL.Add(LITERAL40);



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
                    	// 113:22: -> ID LITERAL
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_LITERAL.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // TT\\Template.g:114:4: ID ASSIGN NUMBER
                    {
                    	ID41=(IToken)Match(input,ID,FOLLOW_ID_in_assignment766);  
                    	stream_ID.Add(ID41);

                    	ASSIGN42=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment768);  
                    	stream_ASSIGN.Add(ASSIGN42);

                    	NUMBER43=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_assignment770);  
                    	stream_NUMBER.Add(NUMBER43);



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
                    	// 114:22: -> ID NUMBER
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());
                    	    adaptor.AddChild(root_0, stream_NUMBER.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // TT\\Template.g:115:4: ID ASSIGN DECIMAL
                    {
                    	ID44=(IToken)Match(input,ID,FOLLOW_ID_in_assignment782);  
                    	stream_ID.Add(ID44);

                    	ASSIGN45=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment784);  
                    	stream_ASSIGN.Add(ASSIGN45);

                    	DECIMAL46=(IToken)Match(input,DECIMAL,FOLLOW_DECIMAL_in_assignment786);  
                    	stream_DECIMAL.Add(DECIMAL46);



                    	// AST REWRITE
                    	// elements:          DECIMAL, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 115:22: -> ID DECIMAL
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

 

    public static readonly BitSet FOLLOW_block_in_document485 = new BitSet(new ulong[]{0x0000000000000202UL});
    public static readonly BitSet FOLLOW_TSTART_in_block506 = new BitSet(new ulong[]{0x0600800001416000UL});
    public static readonly BitSet FOLLOW_statement_in_block509 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_TSTOP_in_block511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_getExpr_in_statement524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setExpr_in_statement529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defaultExpr_in_statement534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forEachLoop_in_statement544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement555 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_ID_in_ifStatement557 = new BitSet(new ulong[]{0x0600800001416600UL});
    public static readonly BitSet FOLLOW_TSTOP_in_ifStatement559 = new BitSet(new ulong[]{0x0600800001416200UL});
    public static readonly BitSet FOLLOW_TSTART_in_ifStatement562 = new BitSet(new ulong[]{0x0600800001416000UL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement565 = new BitSet(new ulong[]{0x0000200000000600UL});
    public static readonly BitSet FOLLOW_TSTOP_in_ifStatement567 = new BitSet(new ulong[]{0x0000200000000200UL});
    public static readonly BitSet FOLLOW_TSTART_in_ifStatement570 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_END_in_ifStatement573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOREACH_in_forEachLoop594 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_ID_in_forEachLoop596 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_IN_in_forEachLoop598 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_ID_in_forEachLoop600 = new BitSet(new ulong[]{0x0600800001416600UL});
    public static readonly BitSet FOLLOW_TSTOP_in_forEachLoop602 = new BitSet(new ulong[]{0x0600800001416200UL});
    public static readonly BitSet FOLLOW_TSTART_in_forEachLoop605 = new BitSet(new ulong[]{0x0600800001416000UL});
    public static readonly BitSet FOLLOW_statement_in_forEachLoop608 = new BitSet(new ulong[]{0x0000200000000600UL});
    public static readonly BitSet FOLLOW_TSTOP_in_forEachLoop610 = new BitSet(new ulong[]{0x0000200000000200UL});
    public static readonly BitSet FOLLOW_TSTART_in_forEachLoop613 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_END_in_forEachLoop616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_getExpr639 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_ID_in_getExpr642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_getExpr661 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_getExpr664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_getExpr678 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_ILITERAL_in_getExpr681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_setExpr700 = new BitSet(new ulong[]{0x0400800000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_setExpr704 = new BitSet(new ulong[]{0x0400800000000002UL});
    public static readonly BitSet FOLLOW_DEFAULT_in_defaultExpr726 = new BitSet(new ulong[]{0x0400800000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_defaultExpr729 = new BitSet(new ulong[]{0x0400800000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment751 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment753 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LITERAL_in_assignment755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment766 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment768 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_assignment770 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_assignment782 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment784 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_DECIMAL_in_assignment786 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}