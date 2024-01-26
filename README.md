# 사전 요구사항
- .NET SDK: .NET SDK가 설치되어 있어야 합니다. SDK는 Microsoft .NET 웹사이트에서 다운로드할 수 있습니다.
- Visual Studio Code (VSCode): 코드 편집에는 VSCode를 사용합니다. Visual Studio Code 웹사이트에서 다운로드할 수 있습니다.

# 프로젝트 생성 및 설정

## 웹 애플리케이션

1. 명령 프롬프트에서 디렉토리로 이동

```cmd
D:
cd D:\test\for_musicvirus
```

2. 웹 앱 프로젝트 생성

```cmd
dotnet new webapp -o report
```

3. 프로젝트 폴더로 이동 및 VSCode에서 열기

```cmd
cd report
code .
```

## 웹 API

1. 메인 디렉토리로 이동

```cmd
cd ..
```

2. 웹 API 프로젝트 생성

```cmd
dotnet new webapi -n ReportServer
```

3. 프로젝트 폴더로 이동 및 VSCode에서 열기

```cmd
cd ReportServer
```cmd

## 패키지 추가

1. Newtonsoft.Json 패키지 추가

```cmd
dotnet add package Newtonsoft.Json
```

## 프로젝트 빌드

1. 프로젝트 빌드

```cmd
dotnet build
```

## VSCode에서 프로젝트 열기
프로젝트 빌드 후 VSCode에서 프로젝트를 열어 코드 편집 및 개발을 시작합니다.

## 추가 정보
애플리케이션을 실행하려면 dotnet run 명령어를 사용합니다.
웹 API는 Postman이나 유사한 도구를 사용하여 테스트할 수 있습니다.
이 파일은 프로젝트의 기본 구조를 설정하고 시작하는 데 필요한 기본적인 지침을 제공합니다. 필요에 따라 내용을 수정하거나 추가하여 사용하시면 됩니다.
