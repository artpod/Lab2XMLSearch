<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html">
	</xsl:output>
	<xsl:template match="/">
		<html>
			<body>
				<table border="1">
					<tr>
						<th>Name</th>
						<th>Faculty</th>
						<th>Cathedra</th>
						<th>Average_mark</th>
						<th>Year_of_start</th>
						<th>Number_of_subjects</th>
					</tr>
					<xsl:for-each select="students/students">
						<tr>
							<td>
								<xsl:value-of select="@Name">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Faculty">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Cathedra">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Average_mark">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Year_of_start">
								</xsl:value-of>
							</td>
							<td>
								<xsl:value-of select="@Number_of_subjects">
								</xsl:value-of>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>