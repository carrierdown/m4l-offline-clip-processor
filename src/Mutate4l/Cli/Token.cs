﻿using Mutate4l.Core;
using static Mutate4l.Cli.TokenType;

namespace Mutate4l.Cli
{
    public class Token
    {
        public TokenType Type { get; }
        public string Value { get; }
        public int Position { get; }
        public Clip Clip { get; }
        public OperatorType OperatorType { get; }
        public bool AllValuesFetched { get; private set; }
        public ChildToken NextValue
        {
            get
            {
                if (HasChildren)
                {
                    var val = Children[CurrentIndex++ % Children.Length];
                    if (!AllValuesFetched)
                    {
                        if (CurrentIndex >= Children.Length) AllValuesFetched = true;
                    }
                    return val;
                }
                AllValuesFetched = true;
                return ValueAsChildToken;
            }
        }
        
        private readonly ChildToken[] Children;
        private readonly ChildToken ValueAsChildToken;
        private int CurrentIndex;

        public Token(TokenType type, string value, int position)
        {
            Children = new ChildToken[0];
            Clip = Clip.Empty;
            OperatorType = OperatorType.None;
            ValueAsChildToken = new ChildToken(type, value);

            Type = type;
            Value = value;
            Position = position;
        }

        public Token(TokenType type, string value, Clip clip, int position) : this(type, value, position)
        {
            Clip = clip;
        }

        public Token(TokenType type, int position, OperatorType operatorType, ChildToken[] children) : this(type, "", position)
        {
            OperatorType = operatorType;
            Children = children;
        }

        public bool HasChildren => Children.Length > 0;
        public bool IsClipReference => Type == TokenType.ClipReference;
        public bool IsOption => Type > _OptionsBegin && Type < _OptionsEnd;
        public bool IsCommand => Type > _CommandsBegin && Type < _CommandsEnd;
        public bool IsOperatorToken => Type > _OperatorsBegin && Type < _OperatorsEnd;
        public bool HasOperatorType => OperatorType != OperatorType.None;
        public bool IsOptionValue => IsEnumValue || IsValue;
        public bool IsEnumValue => Type > _EnumValuesBegin && Type < _EnumValuesEnd;
        public bool IsValue => Type > _ValuesBegin && Type < _ValuesEnd;
        public bool IsPureValue => Type > _ValuesBegin && Type < _PureValuesEnd;
    }
}
