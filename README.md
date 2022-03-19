# DesignPattern
=================================

 특정 디자인패턴인줄 모르고 사용해왔던 패턴들에 대해 정리하고자 합니다. 

- Facade Pattern
- Strategy
- TemplateMethod
- Command

그 밖의 패턴
- Builder
- Singleton

패턴을 분류하는 기준은 두 가지입니다. 첫 번째 분류 기준은 목적(Purpose)인데요, 다시 말해 패턴이 무엇을 하는지 정의하는 것입니다.

패턴은 <strong>생성, 구조, 행동</strong> 중의 한 가지 목적을 갖습니다. 생성 패턴은 객체의 생성 과정에 관여하는 것이고, 구조 패턴은
클래스나 객체의 합성에 관한 패턴들입니다. 행동 패턴은 클래스나 객체들이 상호작용하는 방법과 책임을 분산하는 방법을 정의합니다.

### 디자인 패턴 영역

|        	|                     생성                     	|                            구조                           	|                                             행동                                             	|
|--------	|:--------------------------------------------:	|:---------------------------------------------------------:	|:--------------------------------------------------------------------------------------------:	|
| 클래스 	| Factory Method                               	| Adapter                                                   	| Interpreter, Template Method                                                                  	|
| 객체   	| Abstract Factory, Builder, Prototype, Singleton 	| Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy 	| Chain of Responsibility, Command, Interpreter, Mediator, Memento, Observer, State, Strategy, Visitor 	|

두 번째 분류 기준은 범위(Scope)입니다. 패턴을 주로 클래스에 적용하는지 아니면 객체에 적용하는지를 구분하는 것입니다. 클래스 패턴은 클래스와 서브클래스 간의 관련성을 다루는 패턴입니다. 관련성은 주로 상속이며 컴파일 타임에 정적으로 결정됩니다.
객체 패턴은 객체 관련성을 다루는 패턴으로서, 런타임에 변경할 수 있으며 더 동적인 성격을 가집니다. 대부분의 패턴들은 어느 정도 상속을 이용합니다.

[ 참고 ]
GoF 디자인패턴