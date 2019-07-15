pipeline {

	environment {
		msbuild =  "%windir%/Microsoft.NET/Framework/v4.0.30319/MsBuild.exe"
		novaMsBuild = "RomanNumbersConverter.msbuild"
		nologo = "/nologo"
	}

	agent any
    
  triggers {
    pollSCM('') // Enabling being build on Push
  }
  
  stages {
  
    stage('Build App with MsBuild') {
		steps {
			echo 'Build App with MsBuild'
			
			bat("echo 'Haj'")
			
			${novaMsBuild} ${nologo} /target:BuildApp
			
			bat "\"${tool 'MSBuild'}\" RomanNumbersConverter.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
	
		}
	
    }

	stage('Step 3') {
		when {
			// check if branch is master
            branch 'master'
        }
		steps {
			echo "This is master"
		}
	}
	
  }
  post {
        always {
            echo 'This will always run'
        }
        success {
            echo 'This will run only if successful'
        }
        failure {
            echo 'This will run only if failed'
        }
        unstable {
            echo 'This will run only if the run was marked as unstable'
        }
        changed {
            echo 'This will run only if the state of the Pipeline has changed'
            echo 'For example, if the Pipeline was previously failing but is now successful'
        }
    }
}