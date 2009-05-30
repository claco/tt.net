// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 TT\\Template.g 2009-05-30 12:01:50

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace TT
{
public partial class TemplateLexer : Lexer {
    public const int WHILE = 23;
    public const int CASE = 29;
    public const int CHAR = 55;
    public const int RAWPERL = 34;
    public const int SUB = 50;
    public const int ID = 45;
    public const int EOF = -1;
    public const int IF = 24;
    public const int TSTART = 8;
    public const int T__56 = 56;
    public const int FINAL = 38;
    public const int TSTOP = 9;
    public const int QUOTE = 10;
    public const int INSERT = 17;
    public const int COMMENTS = 44;
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
    public const int FILTER = 31;
    public const int ASSIGN = 53;
    public const int FOREACH = 22;
    public const int CALL = 15;
    public const int USE = 32;
    public const int ELSIF = 26;
    public const int DIV = 52;
    public const int CATCH = 37;
    public const int PROCESS = 18;
    public const int MACRO = 30;
    public const int THROW = 36;

    // delegates
    // delegators

    public TemplateLexer() 
    {
		InitializeCyclicDFAs();
    }
    public TemplateLexer(ICharStream input)
		: this(input, null) {
    }
    public TemplateLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "TT\\Template.g";} 
    }

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:9:7: ( 'GET' )
            // TT\\Template.g:9:9: 'GET'
            {
            	Match("GET"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "TSTART"
    public void mTSTART() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TSTART;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:20:8: ( '[%' ( WS )? )
            // TT\\Template.g:20:10: '[%' ( WS )?
            {
            	Match("[%"); 

            	// TT\\Template.g:20:15: ( WS )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( ((LA1_0 >= '\t' && LA1_0 <= '\n') || LA1_0 == '\r' || LA1_0 == ' ') )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // TT\\Template.g:20:15: WS
            	        {
            	        	mWS(); 

            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TSTART"

    // $ANTLR start "TSTOP"
    public void mTSTOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TSTOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:21:7: ( ( WS )? '%]' )
            // TT\\Template.g:21:9: ( WS )? '%]'
            {
            	// TT\\Template.g:21:9: ( WS )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( ((LA2_0 >= '\t' && LA2_0 <= '\n') || LA2_0 == '\r' || LA2_0 == ' ') )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // TT\\Template.g:21:9: WS
            	        {
            	        	mWS(); 

            	        }
            	        break;

            	}

            	Match("%]"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TSTOP"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:22:4: ( ( '\\r' | '\\n' | '\\t' | ' ' )+ )
            // TT\\Template.g:22:6: ( '\\r' | '\\n' | '\\t' | ' ' )+
            {
            	// TT\\Template.g:22:6: ( '\\r' | '\\n' | '\\t' | ' ' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // TT\\Template.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	 _channel=HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "QUOTE"
    public void mQUOTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = QUOTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:23:7: ( '\"' )
            // TT\\Template.g:23:9: '\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "QUOTE"

    // $ANTLR start "SQUOTE"
    public void mSQUOTE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SQUOTE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:24:8: ( '\\'' )
            // TT\\Template.g:24:10: '\\''
            {
            	Match('\''); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SQUOTE"

    // $ANTLR start "ILITERAL"
    public void mILITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ILITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:25:9: ( QUOTE ( . )* QUOTE )
            // TT\\Template.g:25:11: QUOTE ( . )* QUOTE
            {
            	mQUOTE(); 
            	// TT\\Template.g:25:17: ( . )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == '\"') )
            	    {
            	        alt4 = 2;
            	    }
            	    else if ( ((LA4_0 >= '\u0000' && LA4_0 <= '!') || (LA4_0 >= '#' && LA4_0 <= '\uFFFF')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // TT\\Template.g:25:17: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	mQUOTE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ILITERAL"

    // $ANTLR start "LITERAL"
    public void mLITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:26:9: ( SQUOTE ( . )* SQUOTE )
            // TT\\Template.g:26:11: SQUOTE ( . )* SQUOTE
            {
            	mSQUOTE(); 
            	// TT\\Template.g:26:18: ( . )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == '\'') )
            	    {
            	        alt5 = 2;
            	    }
            	    else if ( ((LA5_0 >= '\u0000' && LA5_0 <= '&') || (LA5_0 >= '(' && LA5_0 <= '\uFFFF')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // TT\\Template.g:26:18: .
            			    {
            			    	MatchAny(); 

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	mSQUOTE(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LITERAL"

    // $ANTLR start "SET"
    public void mSET() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SET;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:27:5: ( 'SET' )
            // TT\\Template.g:27:7: 'SET'
            {
            	Match("SET"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SET"

    // $ANTLR start "CALL"
    public void mCALL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CALL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:28:6: ( 'CALL' )
            // TT\\Template.g:28:8: 'CALL'
            {
            	Match("CALL"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CALL"

    // $ANTLR start "DEFAULT"
    public void mDEFAULT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DEFAULT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:29:9: ( 'DEFAULT' )
            // TT\\Template.g:29:11: 'DEFAULT'
            {
            	Match("DEFAULT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DEFAULT"

    // $ANTLR start "INSERT"
    public void mINSERT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INSERT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:30:8: ( 'INSERT' )
            // TT\\Template.g:30:10: 'INSERT'
            {
            	Match("INSERT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INSERT"

    // $ANTLR start "PROCESS"
    public void mPROCESS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROCESS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:31:9: ( 'PROCESS' )
            // TT\\Template.g:31:11: 'PROCESS'
            {
            	Match("PROCESS"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROCESS"

    // $ANTLR start "INCLUDE"
    public void mINCLUDE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INCLUDE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:32:9: ( 'INCLUDE' )
            // TT\\Template.g:32:11: 'INCLUDE'
            {
            	Match("INCLUDE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INCLUDE"

    // $ANTLR start "WRAPPER"
    public void mWRAPPER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WRAPPER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:33:9: ( 'WRAPPER' )
            // TT\\Template.g:33:11: 'WRAPPER'
            {
            	Match("WRAPPER"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WRAPPER"

    // $ANTLR start "BLOCK"
    public void mBLOCK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BLOCK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:34:7: ( 'BLOCK' )
            // TT\\Template.g:34:9: 'BLOCK'
            {
            	Match("BLOCK"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BLOCK"

    // $ANTLR start "FOREACH"
    public void mFOREACH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOREACH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:35:9: ( 'FOREACH' )
            // TT\\Template.g:35:11: 'FOREACH'
            {
            	Match("FOREACH"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOREACH"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:36:7: ( 'WHILE' )
            // TT\\Template.g:36:9: 'WHILE'
            {
            	Match("WHILE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:37:4: ( 'IF' )
            // TT\\Template.g:37:6: 'IF'
            {
            	Match("IF"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "UNLESS"
    public void mUNLESS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNLESS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:38:8: ( 'UNLESS' )
            // TT\\Template.g:38:10: 'UNLESS'
            {
            	Match("UNLESS"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNLESS"

    // $ANTLR start "ELSIF"
    public void mELSIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSIF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:39:7: ( 'ELSIF' )
            // TT\\Template.g:39:9: 'ELSIF'
            {
            	Match("ELSIF"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSIF"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:40:6: ( 'ELSE' )
            // TT\\Template.g:40:8: 'ELSE'
            {
            	Match("ELSE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "SWITCH"
    public void mSWITCH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SWITCH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:41:8: ( 'SWITCH' )
            // TT\\Template.g:41:10: 'SWITCH'
            {
            	Match("SWITCH"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SWITCH"

    // $ANTLR start "CASE"
    public void mCASE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CASE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:42:6: ( 'CASE' )
            // TT\\Template.g:42:8: 'CASE'
            {
            	Match("CASE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CASE"

    // $ANTLR start "MACRO"
    public void mMACRO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MACRO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:43:7: ( 'MACRO' )
            // TT\\Template.g:43:9: 'MACRO'
            {
            	Match("MACRO"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MACRO"

    // $ANTLR start "FILTER"
    public void mFILTER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FILTER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:44:8: ( 'FILTER' )
            // TT\\Template.g:44:10: 'FILTER'
            {
            	Match("FILTER"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FILTER"

    // $ANTLR start "USE"
    public void mUSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = USE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:45:5: ( 'USE' )
            // TT\\Template.g:45:7: 'USE'
            {
            	Match("USE"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "USE"

    // $ANTLR start "PERL"
    public void mPERL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PERL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:46:6: ( 'PERL' )
            // TT\\Template.g:46:8: 'PERL'
            {
            	Match("PERL"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PERL"

    // $ANTLR start "RAWPERL"
    public void mRAWPERL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RAWPERL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:47:9: ( 'RAWPERL' )
            // TT\\Template.g:47:11: 'RAWPERL'
            {
            	Match("RAWPERL"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RAWPERL"

    // $ANTLR start "TRY"
    public void mTRY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:48:5: ( 'TRY' )
            // TT\\Template.g:48:7: 'TRY'
            {
            	Match("TRY"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRY"

    // $ANTLR start "THROW"
    public void mTHROW() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THROW;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:49:7: ( 'THROW' )
            // TT\\Template.g:49:9: 'THROW'
            {
            	Match("THROW"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THROW"

    // $ANTLR start "CATCH"
    public void mCATCH() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CATCH;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:50:7: ( 'CATCH' )
            // TT\\Template.g:50:9: 'CATCH'
            {
            	Match("CATCH"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CATCH"

    // $ANTLR start "FINAL"
    public void mFINAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FINAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:51:7: ( 'FINAL' )
            // TT\\Template.g:51:9: 'FINAL'
            {
            	Match("FINAL"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FINAL"

    // $ANTLR start "NEXT"
    public void mNEXT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEXT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:52:6: ( 'NEXT' )
            // TT\\Template.g:52:8: 'NEXT'
            {
            	Match("NEXT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEXT"

    // $ANTLR start "LAST"
    public void mLAST() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LAST;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:53:6: ( 'LAST' )
            // TT\\Template.g:53:8: 'LAST'
            {
            	Match("LAST"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LAST"

    // $ANTLR start "RETURN"
    public void mRETURN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RETURN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:54:8: ( 'RETURN' )
            // TT\\Template.g:54:10: 'RETURN'
            {
            	Match("RETURN"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RETURN"

    // $ANTLR start "STOP"
    public void mSTOP() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STOP;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:55:6: ( 'STOP' )
            // TT\\Template.g:55:8: 'STOP'
            {
            	Match("STOP"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STOP"

    // $ANTLR start "TAGS"
    public void mTAGS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TAGS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:56:6: ( 'TAGS' )
            // TT\\Template.g:56:8: 'TAGS'
            {
            	Match("TAGS"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TAGS"

    // $ANTLR start "COMMENTS"
    public void mCOMMENTS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENTS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:57:9: ( 'COMMENTS' )
            // TT\\Template.g:57:11: 'COMMENTS'
            {
            	Match("COMMENTS"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENTS"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:58:4: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' )* )
            // TT\\Template.g:58:6: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// TT\\Template.g:58:30: ( 'a' .. 'z' | 'A' .. 'Z' | '_' )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= 'A' && LA6_0 <= 'Z') || LA6_0 == '_' || (LA6_0 >= 'a' && LA6_0 <= 'z')) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // TT\\Template.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "DIGIT"
    public void mDIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIGIT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:59:7: ( ( '0' .. '9' ) )
            // TT\\Template.g:59:9: ( '0' .. '9' )
            {
            	// TT\\Template.g:59:9: ( '0' .. '9' )
            	// TT\\Template.g:59:10: '0' .. '9'
            	{
            		MatchRange('0','9'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:60:8: ( ( DIGIT )+ )
            // TT\\Template.g:60:10: ( DIGIT )+
            {
            	// TT\\Template.g:60:10: ( DIGIT )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // TT\\Template.g:60:10: DIGIT
            			    {
            			    	mDIGIT(); 

            			    }
            			    break;

            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee7 =
            		                new EarlyExitException(7, input);
            		            throw eee7;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "DECIMAL"
    public void mDECIMAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DECIMAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:61:9: ( DIGIT '.' DIGIT )
            // TT\\Template.g:61:11: DIGIT '.' DIGIT
            {
            	mDIGIT(); 
            	Match('.'); 
            	mDIGIT(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DECIMAL"

    // $ANTLR start "ADD"
    public void mADD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ADD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:62:5: ( '+' )
            // TT\\Template.g:62:7: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ADD"

    // $ANTLR start "SUB"
    public void mSUB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:63:5: ( '-' )
            // TT\\Template.g:63:7: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUB"

    // $ANTLR start "MULT"
    public void mMULT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:64:6: ( '*' )
            // TT\\Template.g:64:8: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULT"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:65:5: ( '/' )
            // TT\\Template.g:65:7: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:66:8: ( '=' )
            // TT\\Template.g:66:10: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "EQUAL"
    public void mEQUAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:67:7: ( '==' )
            // TT\\Template.g:67:9: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUAL"

    // $ANTLR start "CHAR"
    public void mCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CHAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // TT\\Template.g:68:6: ( ( '\\u0000' .. '\\uffff' ) )
            // TT\\Template.g:68:8: ( '\\u0000' .. '\\uffff' )
            {
            	// TT\\Template.g:68:8: ( '\\u0000' .. '\\uffff' )
            	// TT\\Template.g:68:9: '\\u0000' .. '\\uffff'
            	{
            		MatchRange('\u0000','\uFFFF'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHAR"

    override public void mTokens() // throws RecognitionException 
    {
        // TT\\Template.g:1:8: ( T__56 | TSTART | TSTOP | WS | QUOTE | SQUOTE | ILITERAL | LITERAL | SET | CALL | DEFAULT | INSERT | PROCESS | INCLUDE | WRAPPER | BLOCK | FOREACH | WHILE | IF | UNLESS | ELSIF | ELSE | SWITCH | CASE | MACRO | FILTER | USE | PERL | RAWPERL | TRY | THROW | CATCH | FINAL | NEXT | LAST | RETURN | STOP | TAGS | COMMENTS | ID | DIGIT | NUMBER | DECIMAL | ADD | SUB | MULT | DIV | ASSIGN | EQUAL | CHAR )
        int alt8 = 50;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // TT\\Template.g:1:10: T__56
                {
                	mT__56(); 

                }
                break;
            case 2 :
                // TT\\Template.g:1:16: TSTART
                {
                	mTSTART(); 

                }
                break;
            case 3 :
                // TT\\Template.g:1:23: TSTOP
                {
                	mTSTOP(); 

                }
                break;
            case 4 :
                // TT\\Template.g:1:29: WS
                {
                	mWS(); 

                }
                break;
            case 5 :
                // TT\\Template.g:1:32: QUOTE
                {
                	mQUOTE(); 

                }
                break;
            case 6 :
                // TT\\Template.g:1:38: SQUOTE
                {
                	mSQUOTE(); 

                }
                break;
            case 7 :
                // TT\\Template.g:1:45: ILITERAL
                {
                	mILITERAL(); 

                }
                break;
            case 8 :
                // TT\\Template.g:1:54: LITERAL
                {
                	mLITERAL(); 

                }
                break;
            case 9 :
                // TT\\Template.g:1:62: SET
                {
                	mSET(); 

                }
                break;
            case 10 :
                // TT\\Template.g:1:66: CALL
                {
                	mCALL(); 

                }
                break;
            case 11 :
                // TT\\Template.g:1:71: DEFAULT
                {
                	mDEFAULT(); 

                }
                break;
            case 12 :
                // TT\\Template.g:1:79: INSERT
                {
                	mINSERT(); 

                }
                break;
            case 13 :
                // TT\\Template.g:1:86: PROCESS
                {
                	mPROCESS(); 

                }
                break;
            case 14 :
                // TT\\Template.g:1:94: INCLUDE
                {
                	mINCLUDE(); 

                }
                break;
            case 15 :
                // TT\\Template.g:1:102: WRAPPER
                {
                	mWRAPPER(); 

                }
                break;
            case 16 :
                // TT\\Template.g:1:110: BLOCK
                {
                	mBLOCK(); 

                }
                break;
            case 17 :
                // TT\\Template.g:1:116: FOREACH
                {
                	mFOREACH(); 

                }
                break;
            case 18 :
                // TT\\Template.g:1:124: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 19 :
                // TT\\Template.g:1:130: IF
                {
                	mIF(); 

                }
                break;
            case 20 :
                // TT\\Template.g:1:133: UNLESS
                {
                	mUNLESS(); 

                }
                break;
            case 21 :
                // TT\\Template.g:1:140: ELSIF
                {
                	mELSIF(); 

                }
                break;
            case 22 :
                // TT\\Template.g:1:146: ELSE
                {
                	mELSE(); 

                }
                break;
            case 23 :
                // TT\\Template.g:1:151: SWITCH
                {
                	mSWITCH(); 

                }
                break;
            case 24 :
                // TT\\Template.g:1:158: CASE
                {
                	mCASE(); 

                }
                break;
            case 25 :
                // TT\\Template.g:1:163: MACRO
                {
                	mMACRO(); 

                }
                break;
            case 26 :
                // TT\\Template.g:1:169: FILTER
                {
                	mFILTER(); 

                }
                break;
            case 27 :
                // TT\\Template.g:1:176: USE
                {
                	mUSE(); 

                }
                break;
            case 28 :
                // TT\\Template.g:1:180: PERL
                {
                	mPERL(); 

                }
                break;
            case 29 :
                // TT\\Template.g:1:185: RAWPERL
                {
                	mRAWPERL(); 

                }
                break;
            case 30 :
                // TT\\Template.g:1:193: TRY
                {
                	mTRY(); 

                }
                break;
            case 31 :
                // TT\\Template.g:1:197: THROW
                {
                	mTHROW(); 

                }
                break;
            case 32 :
                // TT\\Template.g:1:203: CATCH
                {
                	mCATCH(); 

                }
                break;
            case 33 :
                // TT\\Template.g:1:209: FINAL
                {
                	mFINAL(); 

                }
                break;
            case 34 :
                // TT\\Template.g:1:215: NEXT
                {
                	mNEXT(); 

                }
                break;
            case 35 :
                // TT\\Template.g:1:220: LAST
                {
                	mLAST(); 

                }
                break;
            case 36 :
                // TT\\Template.g:1:225: RETURN
                {
                	mRETURN(); 

                }
                break;
            case 37 :
                // TT\\Template.g:1:232: STOP
                {
                	mSTOP(); 

                }
                break;
            case 38 :
                // TT\\Template.g:1:237: TAGS
                {
                	mTAGS(); 

                }
                break;
            case 39 :
                // TT\\Template.g:1:242: COMMENTS
                {
                	mCOMMENTS(); 

                }
                break;
            case 40 :
                // TT\\Template.g:1:251: ID
                {
                	mID(); 

                }
                break;
            case 41 :
                // TT\\Template.g:1:254: DIGIT
                {
                	mDIGIT(); 

                }
                break;
            case 42 :
                // TT\\Template.g:1:260: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 43 :
                // TT\\Template.g:1:267: DECIMAL
                {
                	mDECIMAL(); 

                }
                break;
            case 44 :
                // TT\\Template.g:1:275: ADD
                {
                	mADD(); 

                }
                break;
            case 45 :
                // TT\\Template.g:1:279: SUB
                {
                	mSUB(); 

                }
                break;
            case 46 :
                // TT\\Template.g:1:283: MULT
                {
                	mMULT(); 

                }
                break;
            case 47 :
                // TT\\Template.g:1:288: DIV
                {
                	mDIV(); 

                }
                break;
            case 48 :
                // TT\\Template.g:1:292: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 49 :
                // TT\\Template.g:1:299: EQUAL
                {
                	mEQUAL(); 

                }
                break;
            case 50 :
                // TT\\Template.g:1:305: CHAR
                {
                	mCHAR(); 

                }
                break;

        }

    }


    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa8 = new DFA8(this);
	    this.dfa8.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA8_SpecialStateTransition);
	}

    const string DFA8_eotS =
        "\x01\uffff\x01\x1f\x01\x1d\x01\x21\x01\x1d\x01\x24\x01\x26\x0f"+
        "\x1f\x01\uffff\x01\x42\x04\uffff\x01\x4a\x01\uffff\x01\x1f\x03\uffff"+
        "\x01\x21\x05\uffff\x07\x1f\x01\x56\x12\x1f\x09\uffff\x01\x6a\x01"+
        "\x6b\x09\x1f\x01\uffff\x09\x1f\x01\x7e\x04\x1f\x01\u0084\x04\x1f"+
        "\x02\uffff\x01\x1f\x01\u008a\x01\u008b\x01\u008c\x06\x1f\x01\u0093"+
        "\x07\x1f\x01\uffff\x01\x1f\x01\u009c\x03\x1f\x01\uffff\x01\x1f\x01"+
        "\u00a1\x01\u00a2\x01\u00a3\x01\x1f\x03\uffff\x01\u00a5\x05\x1f\x01"+
        "\uffff\x01\x1f\x01\u00ac\x01\u00ad\x02\x1f\x01\u00b0\x01\x1f\x01"+
        "\u00b2\x01\uffff\x01\u00b3\x02\x1f\x01\u00b6\x03\uffff\x01\u00b7"+
        "\x01\uffff\x02\x1f\x01\u00ba\x03\x1f\x02\uffff\x01\x1f\x01\u00bf"+
        "\x01\uffff\x01\u00c0\x02\uffff\x01\x1f\x01\u00c2\x02\uffff\x01\x1f"+
        "\x01\u00c4\x01\uffff\x01\u00c5\x01\u00c6\x01\u00c7\x01\u00c8\x02"+
        "\uffff\x01\u00c9\x01\uffff\x01\u00ca\x07\uffff";
    const string DFA8_eofS =
        "\u00cb\uffff";
    const string DFA8_minS =
        "\x01\x00\x01\x45\x01\x25\x01\x09\x01\x5d\x02\x00\x01\x45\x01\x41"+
        "\x01\x45\x01\x46\x01\x45\x01\x48\x01\x4c\x01\x49\x01\x4e\x01\x4c"+
        "\x03\x41\x01\x45\x01\x41\x01\uffff\x01\x2e\x04\uffff\x01\x3d\x01"+
        "\uffff\x01\x54\x03\uffff\x01\x09\x05\uffff\x01\x54\x01\x49\x01\x4f"+
        "\x01\x4c\x01\x4d\x01\x46\x01\x43\x01\x41\x01\x4f\x01\x52\x01\x41"+
        "\x01\x49\x01\x4f\x01\x52\x02\x4c\x01\x45\x01\x53\x01\x43\x01\x57"+
        "\x01\x54\x01\x59\x01\x52\x01\x47\x01\x58\x01\x53\x09\uffff\x02\x41"+
        "\x01\x54\x01\x50\x01\x4c\x01\x45\x01\x43\x01\x4d\x01\x41\x01\x45"+
        "\x01\x4c\x01\uffff\x01\x43\x01\x4c\x01\x50\x01\x4c\x01\x43\x01\x45"+
        "\x01\x54\x01\x41\x01\x45\x01\x41\x01\x45\x01\x52\x01\x50\x01\x55"+
        "\x01\x41\x01\x4f\x01\x53\x02\x54\x02\uffff\x01\x43\x03\x41\x01\x48"+
        "\x01\x45\x01\x55\x01\x52\x01\x55\x01\x45\x01\x41\x01\x50\x01\x45"+
        "\x01\x4b\x01\x41\x01\x45\x01\x4c\x01\x53\x01\uffff\x01\x46\x01\x41"+
        "\x01\x4f\x01\x45\x01\x52\x01\uffff\x01\x57\x03\x41\x01\x48\x03\uffff"+
        "\x01\x41\x01\x4e\x01\x4c\x01\x54\x01\x44\x01\x53\x01\uffff\x01\x45"+
        "\x02\x41\x01\x43\x01\x52\x01\x41\x01\x53\x01\x41\x01\uffff\x01\x41"+
        "\x01\x52\x01\x4e\x01\x41\x03\uffff\x01\x41\x01\uffff\x02\x54\x01"+
        "\x41\x01\x45\x01\x53\x01\x52\x02\uffff\x01\x48\x01\x41\x01\uffff"+
        "\x01\x41\x02\uffff\x01\x4c\x01\x41\x02\uffff\x01\x53\x01\x41\x01"+
        "\uffff\x04\x41\x02\uffff\x01\x41\x01\uffff\x01\x41\x07\uffff";
    const string DFA8_maxS =
        "\x01\uffff\x01\x45\x02\x25\x01\x5d\x02\uffff\x01\x57\x01\x4f\x01"+
        "\x45\x01\x4e\x02\x52\x01\x4c\x01\x4f\x01\x53\x01\x4c\x01\x41\x01"+
        "\x45\x01\x52\x01\x45\x01\x41\x01\uffff\x01\x39\x04\uffff\x01\x3d"+
        "\x01\uffff\x01\x54\x03\uffff\x01\x25\x05\uffff\x01\x54\x01\x49\x01"+
        "\x4f\x01\x54\x01\x4d\x01\x46\x01\x53\x01\x7a\x01\x4f\x01\x52\x01"+
        "\x41\x01\x49\x01\x4f\x01\x52\x01\x4e\x01\x4c\x01\x45\x01\x53\x01"+
        "\x43\x01\x57\x01\x54\x01\x59\x01\x52\x01\x47\x01\x58\x01\x53\x09"+
        "\uffff\x02\x7a\x01\x54\x01\x50\x01\x4c\x01\x45\x01\x43\x01\x4d\x01"+
        "\x41\x01\x45\x01\x4c\x01\uffff\x01\x43\x01\x4c\x01\x50\x01\x4c\x01"+
        "\x43\x01\x45\x01\x54\x01\x41\x01\x45\x01\x7a\x01\x49\x01\x52\x01"+
        "\x50\x01\x55\x01\x7a\x01\x4f\x01\x53\x02\x54\x02\uffff\x01\x43\x03"+
        "\x7a\x01\x48\x01\x45\x01\x55\x01\x52\x01\x55\x01\x45\x01\x7a\x01"+
        "\x50\x01\x45\x01\x4b\x01\x41\x01\x45\x01\x4c\x01\x53\x01\uffff\x01"+
        "\x46\x01\x7a\x01\x4f\x01\x45\x01\x52\x01\uffff\x01\x57\x03\x7a\x01"+
        "\x48\x03\uffff\x01\x7a\x01\x4e\x01\x4c\x01\x54\x01\x44\x01\x53\x01"+
        "\uffff\x01\x45\x02\x7a\x01\x43\x01\x52\x01\x7a\x01\x53\x01\x7a\x01"+
        "\uffff\x01\x7a\x01\x52\x01\x4e\x01\x7a\x03\uffff\x01\x7a\x01\uffff"+
        "\x02\x54\x01\x7a\x01\x45\x01\x53\x01\x52\x02\uffff\x01\x48\x01\x7a"+
        "\x01\uffff\x01\x7a\x02\uffff\x01\x4c\x01\x7a\x02\uffff\x01\x53\x01"+
        "\x7a\x01\uffff\x04\x7a\x02\uffff\x01\x7a\x01\uffff\x01\x7a\x07\uffff";
    const string DFA8_acceptS =
        "\x16\uffff\x01\x28\x01\uffff\x01\x2c\x01\x2d\x01\x2e\x01\x2f\x01"+
        "\uffff\x01\x32\x01\uffff\x01\x28\x01\x02\x01\x04\x01\uffff\x01\x03"+
        "\x01\x05\x01\x07\x01\x06\x01\x08\x1a\uffff\x01\x29\x01\x2a\x01\x2b"+
        "\x01\x2c\x01\x2d\x01\x2e\x01\x2f\x01\x31\x01\x30\x0b\uffff\x01\x13"+
        "\x13\uffff\x01\x01\x01\x09\x12\uffff\x01\x1b\x05\uffff\x01\x1e\x05"+
        "\uffff\x01\x25\x01\x0a\x01\x18\x06\uffff\x01\x1c\x08\uffff\x01\x16"+
        "\x04\uffff\x01\x26\x01\x22\x01\x23\x01\uffff\x01\x20\x06\uffff\x01"+
        "\x12\x01\x10\x02\uffff\x01\x21\x01\uffff\x01\x15\x01\x19\x02\uffff"+
        "\x01\x1f\x01\x17\x02\uffff\x01\x0c\x04\uffff\x01\x1a\x01\x14\x01"+
        "\uffff\x01\x24\x01\uffff\x01\x0b\x01\x0e\x01\x0d\x01\x0f\x01\x11"+
        "\x01\x1d\x01\x27";
    const string DFA8_specialS =
        "\x01\x00\x04\uffff\x01\x01\x01\x02\u00c4\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x09\x1d\x02\x03\x02\x1d\x01\x03\x12\x1d\x01\x03\x01\x1d\x01"+
            "\x05\x02\x1d\x01\x04\x01\x1d\x01\x06\x02\x1d\x01\x1a\x01\x18"+
            "\x01\x1d\x01\x19\x01\x1d\x01\x1b\x0a\x17\x03\x1d\x01\x1c\x03"+
            "\x1d\x01\x16\x01\x0d\x01\x08\x01\x09\x01\x10\x01\x0e\x01\x01"+
            "\x01\x16\x01\x0a\x02\x16\x01\x15\x01\x11\x01\x14\x01\x16\x01"+
            "\x0b\x01\x16\x01\x12\x01\x07\x01\x13\x01\x0f\x01\x16\x01\x0c"+
            "\x03\x16\x01\x02\x03\x1d\x01\x16\x01\x1d\x1a\x16\uff85\x1d",
            "\x01\x1e",
            "\x01\x20",
            "\x02\x22\x02\uffff\x01\x22\x12\uffff\x01\x22\x04\uffff\x01"+
            "\x23",
            "\x01\x23",
            "\x00\x25",
            "\x00\x27",
            "\x01\x28\x0e\uffff\x01\x2a\x02\uffff\x01\x29",
            "\x01\x2b\x0d\uffff\x01\x2c",
            "\x01\x2d",
            "\x01\x2f\x07\uffff\x01\x2e",
            "\x01\x31\x0c\uffff\x01\x30",
            "\x01\x33\x09\uffff\x01\x32",
            "\x01\x34",
            "\x01\x36\x05\uffff\x01\x35",
            "\x01\x37\x04\uffff\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "\x01\x3b\x03\uffff\x01\x3c",
            "\x01\x3f\x06\uffff\x01\x3e\x09\uffff\x01\x3d",
            "\x01\x40",
            "\x01\x41",
            "",
            "\x01\x44\x01\uffff\x0a\x43",
            "",
            "",
            "",
            "",
            "\x01\x49",
            "",
            "\x01\x4b",
            "",
            "",
            "",
            "\x02\x22\x02\uffff\x01\x22\x12\uffff\x01\x22\x04\uffff\x01"+
            "\x23",
            "",
            "",
            "",
            "",
            "",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f\x06\uffff\x01\x50\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x55\x0f\uffff\x01\x54",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d\x01\uffff\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\x6c",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "\x01\x7d",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u0080\x03\uffff\x01\x7f",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "",
            "",
            "\x01\u0089",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\u008f",
            "\x01\u0090",
            "\x01\u0091",
            "\x01\u0092",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "",
            "\x01\u009b",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u009d",
            "\x01\u009e",
            "\x01\u009f",
            "",
            "\x01\u00a0",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u00a4",
            "",
            "",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u00a6",
            "\x01\u00a7",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "",
            "\x01\u00ab",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u00ae",
            "\x01\u00af",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u00b1",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u00b4",
            "\x01\u00b5",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "\x01\u00b8",
            "\x01\u00b9",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\u00bd",
            "",
            "",
            "\x01\u00be",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "",
            "\x01\u00c1",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "",
            "\x01\u00c3",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "\x1a\x1f\x04\uffff\x01\x1f\x01\uffff\x1a\x1f",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__56 | TSTART | TSTOP | WS | QUOTE | SQUOTE | ILITERAL | LITERAL | SET | CALL | DEFAULT | INSERT | PROCESS | INCLUDE | WRAPPER | BLOCK | FOREACH | WHILE | IF | UNLESS | ELSIF | ELSE | SWITCH | CASE | MACRO | FILTER | USE | PERL | RAWPERL | TRY | THROW | CATCH | FINAL | NEXT | LAST | RETURN | STOP | TAGS | COMMENTS | ID | DIGIT | NUMBER | DECIMAL | ADD | SUB | MULT | DIV | ASSIGN | EQUAL | CHAR );"; }
        }

    }


    protected internal int DFA8_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA8_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA8_0 == 'G') ) { s = 1; }

                   	else if ( (LA8_0 == '[') ) { s = 2; }

                   	else if ( ((LA8_0 >= '\t' && LA8_0 <= '\n') || LA8_0 == '\r' || LA8_0 == ' ') ) { s = 3; }

                   	else if ( (LA8_0 == '%') ) { s = 4; }

                   	else if ( (LA8_0 == '\"') ) { s = 5; }

                   	else if ( (LA8_0 == '\'') ) { s = 6; }

                   	else if ( (LA8_0 == 'S') ) { s = 7; }

                   	else if ( (LA8_0 == 'C') ) { s = 8; }

                   	else if ( (LA8_0 == 'D') ) { s = 9; }

                   	else if ( (LA8_0 == 'I') ) { s = 10; }

                   	else if ( (LA8_0 == 'P') ) { s = 11; }

                   	else if ( (LA8_0 == 'W') ) { s = 12; }

                   	else if ( (LA8_0 == 'B') ) { s = 13; }

                   	else if ( (LA8_0 == 'F') ) { s = 14; }

                   	else if ( (LA8_0 == 'U') ) { s = 15; }

                   	else if ( (LA8_0 == 'E') ) { s = 16; }

                   	else if ( (LA8_0 == 'M') ) { s = 17; }

                   	else if ( (LA8_0 == 'R') ) { s = 18; }

                   	else if ( (LA8_0 == 'T') ) { s = 19; }

                   	else if ( (LA8_0 == 'N') ) { s = 20; }

                   	else if ( (LA8_0 == 'L') ) { s = 21; }

                   	else if ( (LA8_0 == 'A' || LA8_0 == 'H' || (LA8_0 >= 'J' && LA8_0 <= 'K') || LA8_0 == 'O' || LA8_0 == 'Q' || LA8_0 == 'V' || (LA8_0 >= 'X' && LA8_0 <= 'Z') || LA8_0 == '_' || (LA8_0 >= 'a' && LA8_0 <= 'z')) ) { s = 22; }

                   	else if ( ((LA8_0 >= '0' && LA8_0 <= '9')) ) { s = 23; }

                   	else if ( (LA8_0 == '+') ) { s = 24; }

                   	else if ( (LA8_0 == '-') ) { s = 25; }

                   	else if ( (LA8_0 == '*') ) { s = 26; }

                   	else if ( (LA8_0 == '/') ) { s = 27; }

                   	else if ( (LA8_0 == '=') ) { s = 28; }

                   	else if ( ((LA8_0 >= '\u0000' && LA8_0 <= '\b') || (LA8_0 >= '\u000B' && LA8_0 <= '\f') || (LA8_0 >= '\u000E' && LA8_0 <= '\u001F') || LA8_0 == '!' || (LA8_0 >= '#' && LA8_0 <= '$') || LA8_0 == '&' || (LA8_0 >= '(' && LA8_0 <= ')') || LA8_0 == ',' || LA8_0 == '.' || (LA8_0 >= ':' && LA8_0 <= '<') || (LA8_0 >= '>' && LA8_0 <= '@') || (LA8_0 >= '\\' && LA8_0 <= '^') || LA8_0 == '`' || (LA8_0 >= '{' && LA8_0 <= '\uFFFF')) ) { s = 29; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA8_5 = input.LA(1);

                   	s = -1;
                   	if ( ((LA8_5 >= '\u0000' && LA8_5 <= '\uFFFF')) ) { s = 37; }

                   	else s = 36;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA8_6 = input.LA(1);

                   	s = -1;
                   	if ( ((LA8_6 >= '\u0000' && LA8_6 <= '\uFFFF')) ) { s = 39; }

                   	else s = 38;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae8 =
            new NoViableAltException(dfa.Description, 8, _s, input);
        dfa.Error(nvae8);
        throw nvae8;
    }
 
    
}
}