# Static Analysis

<br>

Our objective this afternoon is to investigate the topic of Static Analysis, and how to incorperate it into our SDLC (Software Development Life Cycle).
Many resources are available to us, and it is recommended that we look byond any service providers (who tend to make marketing material easily accessible).

<br>

+ Some questions that can help direct our research are:
    - What is static analysis?
    - What are the OWASP Top 10?
    - How does static analysis help protect our applications from falling victim to the OWASP Top 10?
    - What is Technical Debt?
    - How can we leverage static analysis to monitor and minimize technical debt?
    - What is a Quality Gate?
    - How can we integrate quality gates into an applitcations CI/CD?
    - What is a New Code Definition, and why is it important to sspecify?
    - What is a Mono-Repo? How does a mono-repo differ from a traditional git-workflow?

<br>

The static analysis provider that we will be using in our training is SonarCloud. SonarCloud is a web based system well suited to use with public repositories. Remember that while we will be using SonarCloud, there are other alternatives available, and the individual situation will dictate which tools we use on a particular project. In your research remember to explore the process of static analysis, not just how SonarCloud accomplishes this process.

<br>

<hr>

<br>

## Explore SonarCloud

Follow the isntructions found in the SonarCloud documentation at https://docs.sonarcloud.io/getting-started/overview/ to run analysis on a project of your own.

1. On GitHub, navigate to your repositories (use the user menu at the top right of the page when signed in)
2. Create a **new repository**.
    - This repository must be public.
3. Clone your new repository to your local system.
4. Copy your P0 project folder into the new repository.
5. Follow the "Getting Started With GitHub" instructions available in SonarClouds documentation.
    - Note the difference between "automatic analysis" and "CI-base analysis".
6. Once set up, review your P0s analysis through SonarCloud.io.
7. Within your repo, set a branch protection policy/rule (repo -> Settings -> Code and Automation -> Branches) to "require status checks before merging".
8. Create a new branch in your repo, and make a modification to your code (a comment will suffice) within the new branch.
9. Open a Pull Request from your new branch to merge into the main branch of your repo.
    - Was your PR successful? Why or why not?
10. On SonarCloud.io, set up or modify your projects Quality Gate. For this practice, you will need to set your new quality gate to the minimum check possible.
11. Set your project to use your new/modified Quality Gate for analysis.
12. Repeat steps 8 and 9 to see how your modification to the qulaity gate effects the Pull Request.
