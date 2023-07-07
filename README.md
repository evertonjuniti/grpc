# PoC - ISO8583

This PoC (Proof of Concept) project aims an implementation using a ISO-8583 library to reduce the payload in any request-response integration between applications.

So far I've implemented only wiht .Net Core programming language, my goal is to compare pure REST Api call vs REST Api call with "compacted" payload using ISO-8583 C dll vs pure gRPC.

To know more about the C project, you can visit Oscar Sanderson ISO-8583 website: [https://oscarsanderson.com/iso-8583/](https://oscarsanderson.com/iso-8583/), you can download the `.tar` files for one of the versions.

In this repository, I've already downloaded one of the versions, you can find the files within `ISO8583_Library\dl_c_iso8583_v0_0_4_160708_allfiles` folder, in which is the one I've used for this PoC.

You can find out how to install the C compiler and how to compile the C project within this repository too! Check the instructions in the README.md file within `ISO8583_Library\dl_c_iso8583_v0_0_4_160708_allfiles` folder.

You can find out how to run the PoC with the given source code in this repository. Check the instructions in the README.md file within 'BFFs' folder.

Is important to know that the BFFs I've create depends on the application I've created in the `generic-api` folder. I've just create a dumb Api using Java Spring Boot with a simple structure to exchange information with each BFF. So you'll need to run this `generic-api` too if you want the BFFs to work! You can use [Eclipse](https://www.eclipse.org/) to run this Java application.